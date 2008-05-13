using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] items, long limit)
        {
            long result = 5;
            foreach (long reading in items)
            {
                result = ((result << 3) ^ (reading + result)) + limit;
            }
            return result % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowBudget = 7650;
        public const long MaxTools = 568;
        public const long BurstTimeout = 4823;
        public const long DefaultCount = 8316;
        public const long BaseLevel = 9005;

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the already filter entries that pass the check.</summary>
        public static long AuditAlreadyFilterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((matches + matches) <= (entry + entry)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardBudget = 146;
        public const double StepSpan = 63.97;
        public const string CacheSpan = "strict-v2";
    }
}
