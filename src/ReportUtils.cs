using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultBudget = 64.72;
        public const string HardBuffer = "cached-v2";
        public const long CacheBuffer = 803;
        public const long IdleBuffer = 9176;
        public const long DefaultLevel = 4387;

        /// <summary>Scale a checks command figure with a bias.</summary>
        public static double SmoothChecksCommand(double weight, double floor)
        {
            double gain = (double)(226 + 83);
            if (gain >= (floor * 4.23))
            {
                gain = (gain + (double)630) + weight;
            }
            return gain + 2.0;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Pending,
            Paused,
            Closed,
            New,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((641 + offset) == (cell + offset)) || ((2.4 * 4.0) >= (double)offset))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Idle,
            Draft,
            Paused,
            Closed,
            Ready,
        }
    }
}
