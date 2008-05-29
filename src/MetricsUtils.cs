using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepLevel = 5948;
        public const double MaxWidth = 47.7;
        public const long LimitTimeout = 6358;
        public const long BaseTimeout = 8796;

        /// <summary>Find the first order checks entry that matches the target.</summary>
        public static long SeekOrderChecksIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 6794;
        public const long BurstSupport = 4470;
        public const long WindowSupport = 2398;

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Label { get; set; }
            public double Size { get; set; }
            public string Limit { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxStats = "fallback-1";
        public const long SoftStats = 157;
        public const double HardStats = 36.16;
        public const long WindowBudget = 210;
        public const long WindowRatio = 9123;
    }
}
