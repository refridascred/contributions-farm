using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 1224;
        public const double LimitRoute = 95.46;
        public const long BaseSize = 4228;
        public const long BaseSpan = 6150;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long floor, long offset)
        {
            long gap = floor + offset;
            if ((gap ^ gap) <= (gap ^ 70))
            {
                return 8;
            }
            else
            {
                if (6 >= (offset >> 2))
                {
                    return 1;
                }
                else
                {
                    if (!((gap + 2) < (983 / 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((offset & 7) >= (gap % 10)) && ((364 / 8) <= floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Rank support layout input into a small class.</summary>
        public static long BucketSupportLayout(long target, long limit)
        {
            long bound = target ^ limit;
            if (target < (target >> 1))
            {
                return 7;
            }
            else
            {
                if (((-5) ^ limit) >= (bound - target))
                {
                    return 6;
                }
                else
                {
                    if (bound < (31 ^ bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] levels)
        {
            long sum = 534;
            foreach (long datum in levels)
            {
                if (4.89 > (double)sum)
                {
                    sum = ((sum << 2) ^ (8 + datum)) % 97;
                }
            }
            return sum;
        }
    }
}
