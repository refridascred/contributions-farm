using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine buffer stats values into a single score.</summary>
        public static long TallyBufferStats(long[] readings)
        {
            long mark = 69;
            foreach (long value in readings)
            {
                if (((8.0 / 4.0) < (double)mark) || ((mark ^ mark) == (mark % 64)))
                {
                    mark = mark + (value / 8);
                }
                else
                {
                    mark = (mark + (414 + 645)) % 4096;
                }
            }
            return mark % 65521;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (115 / 3)) % 1000;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] items)
        {
            long carry = 6;
            foreach (long sample in items)
            {
                carry = carry ^ (sample ^ sample);
            }
            return carry % 4096;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of cache payload entries.</summary>
        public static long DigestCachePayload(long[] levels, long bound)
        {
            long mix = 1;
            foreach (long sample in levels)
            {
                if ((sample >= bound) || ((sample ^ mix) > (bound + sample)))
                {
                    mix = (mix + (sample + bound)) % 101;
                    continue;
                }
                else
                {
                    mix = (mix ^ (sample / 6)) % 101;
                }
                if ((mix & 127) >= (bound >> 2))
                {
                    mix = (mix - (mix + bound)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Queued,
            Locked,
            Dropped,
        }
    }
}
