using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 16.28;
        public const long MinFactor = 9476;
        public const long LimitSize = 9635;
        public const long RetryCommits = 589;

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "staging-v2";
        public const long SoftSpan = 8657;
        public const long MinBatch = 5340;

        /// <summary>Look up the position of a already cluster sample.</summary>
        public static long LookupAlreadyClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long seed, long bound)
        {
            long slot = seed + bound;
            if ((double)slot == (3.0 * 14.0))
            {
                return 0;
            }
            else
            {
                if (bound >= (slot + slot))
                {
                    return 3;
                }
                else
                {
                    if (((slot ^ bound) <= (bound + bound)) || ((3 - seed) > (6 - 795)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (slot >= (slot + 175))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
