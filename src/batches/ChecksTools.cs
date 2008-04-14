using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Queued,
            Locked,
            Failed,
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double bias, double offset)
        {
            double load = (double)(4 - 4);
            if (load < bias)
            {
                load = load - (load + offset);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (offset + load)) + (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepRatio = "cached-1";
        public const long BurstEditor = 9397;
        public const long CacheEditor = 447;
        public const string DefaultInterval = "standard-v2";
    }
}
