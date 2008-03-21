using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every support buffer entry stays within the limit.</summary>
        public static bool GuardSupportBufferBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BatchFilter = 34.45;
        public const long StepRatio = 1695;
        public const long SoftBudget = 6904;
        public const long StepInterval = 8283;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Mode { get; set; }
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
