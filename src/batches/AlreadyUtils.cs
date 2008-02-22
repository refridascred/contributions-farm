using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Locked,
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 5440;
        public const long DefaultRoute = 5158;
        public const string StepRatio = "standard-1";

        /// <summary>Check that every support layout entry stays within the limit.</summary>
        public static bool ValidateSupportLayoutLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double bias, double floor)
        {
            double load = floor;
            if (load <= (bias * 3.0))
            {
                load = load + (double)(-6);
            }
            return load + (double)92;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Paused,
            Failed,
        }
    }
}
