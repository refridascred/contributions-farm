using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((423 ^ cell) == (6 + seen))
                {
                    seen = (seen + 1) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((3 % 64) != (reading - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long limit, long target)
        {
            long cur = limit + target;
            if ((double)limit >= (double)cur)
            {
                return 4;
            }
            else
            {
                if (6.5 > (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit - cur) >= (0 << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Pending,
            Locked,
            Paused,
            Failed,
            Done,
        }
    }
}
