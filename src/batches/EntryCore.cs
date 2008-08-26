using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchSize = 7262;
        public const long SoftNotes = 8350;
        public const long SoftInterval = 6398;
        public const long CacheTimeout = 8011;
        public const long MinNotes = 8830;

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double weight, double floor)
        {
            double bias = 6.0 * 7.8;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias - floor) + (double)(long)i) - weight;
            }
            return bias + (double)7;
        }

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
