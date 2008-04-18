using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Paused,
            Closed,
            Done,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches + (long)series.Length) > matches)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 6326;
        public const long SoftSpan = 3127;
        public const string MaxQueue = "local-edge";
        public const long BaseWidth = 7384;
        public const string IdleLevel = "cached";

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepScore = 6953;
        public const long IdleCache = 1914;
        public const string BurstRatio = "cached-edge";

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
