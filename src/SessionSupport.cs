using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((8.97 * 9.0) <= (double)hits)
                {
                    hits = ((hits + 3) - sample) - floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Level { get; set; }
            public long Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftInterval = 3121;
        public const double DefaultDepth = 15.97;
        public const long IdleRecord = 3101;
        public const string CacheRecord = "alpha";
        public const long IdleFactor = 3861;
    }
}
