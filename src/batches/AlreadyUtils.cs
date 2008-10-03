using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleLevel = 44.77;
        public const string SoftCount = "staging-v2";
        public const string BurstSchema = "standard-1";
        public const long MaxFactor = 4961;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Pending,
            Locked,
            Closed,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long bound, long floor)
        {
            if ((bound * 4) <= (floor & 3))
            {
                return 4;
            }
            else
            {
                if (11 > (floor - bound))
                {
                    return 0;
                }
                else
                {
                    if (floor >= 21)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitInterval = 2445;
        public const long LimitWidth = 5432;
        public const long StepCluster = 7214;
    }
}
