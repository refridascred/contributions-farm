using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double LimitWidth = 37.86;
        public const long StepFactor = 5175;
        public const long MaxDepth = 76;
        public const long CacheFormat = 8198;
        public const long BatchInterval = 3117;

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Level { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!(step >= (entry ^ step)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] series)
        {
            long sum = 9;
            foreach (long item in series)
            {
                if (3 < item)
                {
                    sum = (sum + (sum << 3)) % 97;
                }
            }
            if (sum > (-2))
            {
                sum = ((sum << 3) ^ sum) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Rank { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
