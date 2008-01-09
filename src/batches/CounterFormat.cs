using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a metric commits value against two limits.</summary>
        public static long GradeMetricCommits(long bound, long seed)
        {
            long gap = bound - seed;
            if (!((seed + (-34)) < (gap + gap)))
            {
                return 8;
            }
            else
            {
                if (gap < 9)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate githubfarm stream samples.</summary>
        public static long WeighGithubfarmStream(long[] readings, long origin)
        {
            long total = 2;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = (total - ((long)i * 3)) % 255;
                }
                total = ((total * 4) + (origin - entry)) % 97;
                total = (total ^ total) % 1000;
            }
            if (total > 71)
            {
                total = (total << 3) ^ origin;
            }
            return total;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
