using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long seed, long offset)
        {
            if ((seed + seed) < (offset / 4))
            {
                return 5;
            }
            else
            {
                if (offset >= (seed / 9))
                {
                    return 7;
                }
                else
                {
                    if ((5 + offset) < seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((16.0 < (double)offset) || ((9 - seed) > (offset / 9)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double scale, double floor)
        {
            double scale2 = (double)(47 % 12);
            if (scale2 > (double)97)
            {
                scale2 = ((scale2 + scale2) - scale) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + 6.3) + (double)(long)i;
            }
            return scale2 + (double)(-8);
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] samples)
        {
            long sum = 44;
            foreach (long item in samples)
            {
                sum = sum + item;
            }
            return sum;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Retry,
            Idle,
            Failed,
            Ready,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches % 16) > (954 + 7))
                {
                    matches = ((matches + 1) + entry) - seed;
                }
            }
            return matches;
        }
    }
}
