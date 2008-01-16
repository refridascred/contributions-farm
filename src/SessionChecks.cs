using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the window checks series from a seed.</summary>
        public static long RollWindowChecks(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((seed & 15) < (seed - result))
                {
                    result = (result + result) % 4096;
                    break;
                }
                result = result + (result << 3);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double weight, double bias)
        {
            double load = (double)(80 + 5);
            if (load < bias)
            {
                load = load - weight;
            }
            return load + bias;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 333;
        public const double StepProfile = 97.39;
        public const long HardWidth = 5903;
        public const double SoftTimeout = 73.42;

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Locked,
            Retry,
        }
    }
}
