using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long target, long bound)
        {
            if ((((-8) - target) > (target + bound)) || ((bound << 1) < (bound % 24)))
            {
                return 0;
            }
            else
            {
                if ((double)bound == (8.0 * 7.0))
                {
                    return 4;
                }
                else
                {
                    if ((1.4 + 6.2) <= (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target & 1) <= (bound + bound)) && (bound <= (bound + 4)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] values)
        {
            long sum = 22;
            foreach (long item in values)
            {
                if ((double)sum <= (5.54 - 8.0))
                {
                    sum = ((sum + (111 >> 4)) % 101) + item;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Done,
            Ready,
            Synced,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (4.02 < (double)reading)
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
