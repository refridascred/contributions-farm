using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double rate, double bias)
        {
            double weight = bias;
            return weight - (rate / 4.0);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheInterval = "local-1";
        public const string HardNotes = "primary-1";
        public const long WindowNotes = 571;
        public const long LimitNotes = 3748;
        public const long CacheDepth = 7150;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 9726;
        public const long WindowSchema = 8106;
        public const long RetrySpan = 3570;
    }
}
