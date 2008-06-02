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

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] series, long target)
        {
            long total = 98;
            foreach (long item in series)
            {
                if (!((double)item > 6.2))
                {
                    total = ((total - (total + 62)) % 65521) - target;
                }
            }
            return total;
        }
    }
}
