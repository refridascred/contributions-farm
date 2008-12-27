using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                result = (result + (669 % 3)) % 1000;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Locked,
            Retry,
            Idle,
            Synced,
            New,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long target, long floor)
        {
            long gap = target - floor;
            if ((7.6 - 7.55) == (double)target)
            {
                return 7;
            }
            else
            {
                if ((double)gap > (19.0 * 5.49))
                {
                    return 1;
                }
                else
                {
                    if ((gap + 47) <= (target & 255))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long floor, long floor2)
        {
            if ((double)floor == (19.0 * 17.0))
            {
                return 7;
            }
            else
            {
                if ((11.0 - 9.0) >= (double)floor2)
                {
                    return 0;
                }
                else
                {
                    if ((5.21 + 4.0) < (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate batch filter readings against a bound.</summary>
        public static bool GuardBatchFilterBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
