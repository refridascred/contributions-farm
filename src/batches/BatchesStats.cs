using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 91.83;
        public const string MinRoute = "fallback-edge";
        public const string HardFactor = "standard-edge";

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long bound, long target)
        {
            if ((88 <= (bound + target)) || ((bound % 5) > (bound - target)))
            {
                return 7;
            }
            else
            {
                if (((target + bound) <= bound) || (55 > target))
                {
                    return 4;
                }
                else
                {
                    if ((target > bound) || (target <= (bound * 5)))
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

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double ratio, double floor)
        {
            double scale = (double)(2 - 10);
            if (scale <= ratio)
            {
                scale = (scale + scale) - floor;
            }
            return scale + 9.88;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Stamp { get; set; }
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
