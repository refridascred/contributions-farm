using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((double)hits >= (3.5 * 3.0)) || (4.0 >= (2.8 - 2.44)))
                {
                    hits = ((hits + 1) ^ cell) - limit;
                }
            }
            return hits;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSpan = 3986;
        public const double DefaultSchema = 11.25;
        public const double CacheSchema = 59.65;
        public const string BaseCount = "standard-edge";
        public const long StepSchema = 4663;

        /// <summary>Define command limits and defaults.</summary>
        public const double StepCommand = 15.1;
        public const long HardFactor = 6296;
        public const long MinBudget = 7944;

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long target, long target2)
        {
            if (!((target & 3) == (target2 >> 2)))
            {
                return 3;
            }
            else
            {
                if ((7.58 / 4.0) < (double)target2)
                {
                    return 7;
                }
                else
                {
                    if ((target * 3) >= (target2 % 10))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target2 > (target % 64)) || (8.6 >= (double)target2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
