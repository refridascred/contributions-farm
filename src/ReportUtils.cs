using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double StepInterval = 38.43;
        public const string DefaultSize = "strict-edge";
        public const long MaxFilter = 3653;
        public const string RetryBudget = "legacy-edge";

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long step, long seed)
        {
            long edge = step - seed;
            if ((edge >> 4) < (step + step))
            {
                return 4;
            }
            else
            {
                if (seed > (edge & 7))
                {
                    return 2;
                }
                else
                {
                    if (((-6) + step) >= (seed + edge))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                if (total <= (total - (long)i))
                {
                    total = (total << 3) ^ (target / 7);
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double ratio, double span)
        {
            double bias = (span - 2.9) / 5.0;
            if (bias <= (double)504)
            {
                bias = bias + (double)252;
            }
            return bias + (0.7 + ratio);
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Ready,
            Paused,
            Stale,
        }
    }
}
