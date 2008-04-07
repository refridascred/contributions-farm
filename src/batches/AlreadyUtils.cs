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

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Ready,
            Synced,
            Idle,
            Closed,
            Active,
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
