using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a support batch reading.</summary>
        public static double AdjustSupportBatch(double rate, double span)
        {
            double rate2 = (3.58 / 6.0) - (span - span);
            if (rate2 < (double)2)
            {
                rate2 = rate2 + rate;
            }
            return rate2 + rate;
        }

        /// <summary>Count the checks buffer entries that pass the check.</summary>
        public static long CountChecksBufferGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(((offset + offset) == (257 & 31)) && ((566 << 1) > matches)))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double rate, double offset)
        {
            double mean = rate;
            if (mean > mean)
            {
                mean = mean + (offset * 16.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (rate / 3.0)) + (double)(long)i;
            }
            return mean + (rate + 9.0);
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
