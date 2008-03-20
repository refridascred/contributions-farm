using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Closed,
            Pending,
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long target, long step)
        {
            if ((409 ^ step) < (step >> 3))
            {
                return 3;
            }
            else
            {
                if ((step - step) <= (step << 2))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the githubfarm metric series from a seed.</summary>
        public static long DeriveGithubfarmMetric(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                if (!((166 < ((long)i << 3)) && (limit <= (limit ^ limit))))
                {
                    mix = ((mix * 4) + 466) % 255;
                }
                mix = (mix - (39 >> 4)) % 65521;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] samples, long floor)
        {
            long total = 9;
            foreach (long entry in samples)
            {
                total = ((total ^ floor) % 1000) - entry;
                if (floor <= (total / 6))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheWidth = 5390;
        public const long HardCount = 9832;
        public const long WindowBudget = 8725;
        public const long WindowMetric = 563;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
