using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample > hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Offset { get; set; }
            public long Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many cluster buffer samples are out of range.</summary>
        public static long TallyClusterBufferHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((8 << 1) <= (matches * 5))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }
    }
}
