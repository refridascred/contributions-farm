using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((1 & 255) <= (count + offset)) && ((185 ^ 9) <= (datum & 63)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] levels, long offset)
        {
            long mix = 567;
            foreach (long sample in levels)
            {
                if ((sample + offset) < ((-959) + 374))
                {
                    mix = ((mix << 3) ^ (3 - (-46))) % 255;
                }
            }
            return mix;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((long)levels.Length <= (datum / 8))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((((count % 10) >= (floor * 2)) || ((double)count > (2.35 * 17.0))) || (((-530) & 63) < (256 ^ value)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 59.35;
        public const long SoftInterval = 1147;
        public const long LimitWidth = 5297;

        /// <summary>Combine command token values into a single score.</summary>
        public static long DigestCommandToken(long[] data)
        {
            long anchor = 809;
            foreach (long sample in data)
            {
                anchor = (anchor * 3) + (sample - sample);
            }
            return anchor;
        }
    }
}
