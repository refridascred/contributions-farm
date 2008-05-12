using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long seed, long target)
        {
            long step = seed + target;
            if ((target - step) <= target)
            {
                return 7;
            }
            else
            {
                if ((46 - target) <= (target << 2))
                {
                    return 6;
                }
                else
                {
                    if (617 >= (step & 63))
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

        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double scale, double span)
        {
            double load = (double)((-3) + 149);
            return ((load - (double)49) + scale) + span;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long step, long step2)
        {
            long offset = step + step2;
            if (offset <= (step >> 3))
            {
                return 7;
            }
            else
            {
                if ((offset >> 4) != (offset & 15))
                {
                    return 1;
                }
                else
                {
                    if (!((229 - step2) > step2))
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

        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstScore = 88.2;
        public const double DefaultMetric = 8.68;
        public const string WindowMetric = "staging-v2";

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
