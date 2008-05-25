using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double rate, double span)
        {
            double scale = (double)(1 + 225);
            if (scale >= span)
            {
                scale = scale + 9.0;
            }
            return scale - (rate - span);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxInterval = 4744;
        public const double BatchBudget = 26.46;
        public const double SoftQueue = 31.44;
        public const long StepRatio = 8634;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            Done,
            Closed,
            Synced,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultBudget = 4931;
        public const string WindowContributi = "fallback-edge";
        public const long DefaultSize = 3234;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
