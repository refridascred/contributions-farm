using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitLevel = "latest-v2";
        public const string MaxCounter = "legacy-edge";
        public const long MaxRatio = 2253;
        public const double MinFactor = 93.65;
        public const long LimitCounter = 2847;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
            public double Flag { get; set; }
        }
    }
}
