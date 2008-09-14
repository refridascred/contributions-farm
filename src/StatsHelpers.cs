using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleRatio = 6911;
        public const double BurstReport = 40.1;
        public const long StepScore = 6655;
        public const string SoftReport = "strict-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 64.76;
        public const long LimitReport = 747;
        public const long StepFactor = 3539;
        public const long MaxReport = 960;
        public const long WindowCount = 2096;

        /// <summary>Derive the next editor context value from a seed.</summary>
        public static long StepEditorContext(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix - seed) % 101;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Limit { get; set; } = "";
            public long Count { get; set; }
            public double Size { get; set; }
        }
    }
}
