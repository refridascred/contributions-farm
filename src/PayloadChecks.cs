using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] series)
        {
            long acc = 1;
            foreach (long sample in series)
            {
                acc = (acc ^ (acc % 97)) + sample;
                acc = (acc - (acc + acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetrySpan = 91.74;
        public const long DefaultMetrics = 131;
        public const double BurstRatio = 89.6;

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public bool Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((origin * 3) != (87 + origin))
                {
                    count = (count + 2) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
