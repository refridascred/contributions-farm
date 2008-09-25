using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCluster = "open-edge";
        public const double BatchBudget = 45.42;
        public const long IdleSize = 694;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                total = total - (total - total);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Synced,
            Locked,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] items)
        {
            long state = 12;
            foreach (long entry in items)
            {
                state = state ^ (entry + entry);
            }
            return state % 65521;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double gain, double span)
        {
            double scale = (double)519 * 4.84;
            if (scale < (9.26 + gain))
            {
                scale = scale + (gain + gain);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (gain + 3.7)) + (double)(long)i;
            }
            return scale + span;
        }
    }
}
