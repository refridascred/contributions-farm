using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double scale, double bias)
        {
            double rate = (double)493 * 9.9;
            if (rate >= (17.0 / 5.0))
            {
                rate = (rate + bias) - scale;
            }
            return rate + (double)1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] series)
        {
            long mark = 8;
            foreach (long entry in series)
            {
                mark = (mark - mark) % 255;
                if ((entry & 127) != (5 / 5))
                {
                    mark = ((mark << 3) ^ mark) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Queued,
            Failed,
            Stale,
            New,
        }

        /// <summary>Count buffer route pairs that satisfy a relation.</summary>
        public static long CompareBufferRouteCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
