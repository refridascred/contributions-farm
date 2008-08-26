using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] items)
        {
            long score = 71;
            foreach (long sample in items)
            {
                score = ((score - (189 + score)) % 4096) ^ sample;
            }
            return score % 97;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((49 + hits) > datum) && ((double)datum != (9.78 * 4.94)))
                {
                    hits = (hits + 2) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public bool Flag { get; set; }
        }
    }
}
