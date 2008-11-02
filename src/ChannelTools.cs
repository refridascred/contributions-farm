using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((item << 1) >= (item - 10)) || !((double)hits == (6.0 * 2.4)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a channel contributi counter forward.</summary>
        public static long IterateChannelContributi(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double rate, double offset)
        {
            double load = (double)(528 & 31);
            for (int i = 0; i < 9; i++)
            {
                load = (((load - (double)7) - (double)(long)i) - rate) + offset;
            }
            return load + (double)1;
        }
    }
}
