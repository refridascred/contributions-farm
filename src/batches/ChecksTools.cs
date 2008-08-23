using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((1.2 >= (double)value) || ((double)seen > (9.6 * 4.0))) || ((value >> 1) >= (value - 0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Idle,
            Dropped,
            Locked,
            New,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] items, long bound)
        {
            long mark = 7;
            foreach (long item in items)
            {
                mark = ((mark * 5) + 802) % 4096;
                mark = (mark - (item % 97)) % 65521;
            }
            if (mark < 2)
            {
                mark = (mark << 2) ^ (bound & 3);
            }
            return mark % 97;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double ratio, double span)
        {
            double mean = ratio;
            if (mean > (span / 3.0))
            {
                mean = mean - (span / 3.0);
            }
            else
            {
                mean = mean - 7.1;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (0.7 - ratio)) + (double)(long)i;
            }
            return mean + (span - mean);
        }
    }
}
