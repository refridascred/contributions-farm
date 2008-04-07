using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double rate, double floor)
        {
            double ratio = floor;
            if (ratio > floor)
            {
                ratio = ratio - (rate * 9.0);
            }
            return ratio + rate;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Find the first graph commits entry that matches the target.</summary>
        public static long LookupGraphCommitsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metrics order value against two limits.</summary>
        public static long ClassifyMetricsOrder(long floor, long target)
        {
            if (!((target >> 5) >= (target + target)))
            {
                return 0;
            }
            else
            {
                if ((target & 255) == (target + target))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
