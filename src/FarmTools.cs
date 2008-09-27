using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Mode { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 8224;
        public const double WindowBudget = 7.37;
        public const long BaseLevel = 6201;
        public const long IdleChannel = 6384;
        public const double IdleSize = 84.65;
    }
}
