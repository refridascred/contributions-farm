using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 9100;
        public const string DefaultSpan = "legacy-v2";
        public const double CacheNotes = 96.79;
        public const long DefaultNotes = 5237;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long floor, long limit)
        {
            long delta = floor + limit;
            if (floor >= delta)
            {
                return 4;
            }
            else
            {
                if ((94 / 5) >= limit)
                {
                    return 5;
                }
                else
                {
                    if ((delta >> 3) > (floor ^ limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long offset, long step)
        {
            long cur = offset + step;
            if ((double)step < (10.0 / 8.0))
            {
                return 1;
            }
            else
            {
                if (!((step << 2) > (step - 7)))
                {
                    return 3;
                }
                else
                {
                    if ((step ^ offset) > (cur - step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
