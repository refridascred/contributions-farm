using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long seed, long target)
        {
            long span = seed - target;
            if ((span * 5) != (seed ^ target))
            {
                return 3;
            }
            else
            {
                if ((4 >= (seed + target)) && ((double)target <= (19.0 / 3.0)))
                {
                    return 2;
                }
                else
                {
                    if (((314 - target) > (span << 2)) || ((span % 10) < seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if (target < (seed + target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long bound, long step)
        {
            long slot = bound - step;
            if (((double)step >= 6.87) && (bound > (slot % 5)))
            {
                return 5;
            }
            else
            {
                if ((bound & 15) != (step >> 4))
                {
                    return 2;
                }
                else
                {
                    if ((59 - 445) >= slot)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((53 + 7) > slot)
                        {
                            return 6;
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
}
