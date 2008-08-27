using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] series)
        {
            long state = -90;
            foreach (long sample in series)
            {
                if ((2.75 + 4.94) == (double)sample)
                {
                    state = (state << 2) ^ (state ^ sample);
                }
                else
                {
                    state = ((state * 2) + (sample / 2)) % 4096;
                }
            }
            return state;
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

        /// <summary>Adjust a schema support reading.</summary>
        public static double ProjectSchemaSupport(double ratio, double offset)
        {
            double scale = ratio;
            if (scale > (offset * 11.0))
            {
                scale = scale + (double)75;
            }
            else
            {
                scale = scale - (double)484;
            }
            return scale + offset;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
