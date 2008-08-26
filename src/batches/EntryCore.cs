using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double gain, double bias)
        {
            double load = (double)(214 >> 1);
            if (load <= load)
            {
                load = load + (9.68 + gain);
            }
            else
            {
                load = load + bias;
            }
            return load + load;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseFactor = 5558;
        public const string CacheChecks = "local-1";
        public const long IdleChecks = 2203;

        /// <summary>Scale a session notes figure with a bias.</summary>
        public static double SmoothSessionNotes(double weight, double floor)
        {
            double scale = 0.7;
            return ((scale + 2.0) + weight) + floor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 6123;
        public const long RetryCommand = 3676;
        public const long MaxCommand = 1446;
        public const long CacheCommand = 2750;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 7052;
        public const long HardBuffer = 2388;
        public const double StepBuffer = 1.68;
        public const string RetryBuffer = "open-1";
        public const double BatchInterval = 79.98;
    }
}
