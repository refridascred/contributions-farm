using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long bound, long step)
        {
            if ((bound <= (bound + step)) || ((bound ^ step) >= 8))
            {
                return 5;
            }
            else
            {
                if ((double)bound == (7.3 * 3.1))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double WindowToken = 32.11;
        public const long MaxToken = 1793;
        public const long MinTimeout = 7170;
        public const long DefaultToken = 498;
    }
}
