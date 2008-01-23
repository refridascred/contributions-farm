using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of metric cache entries.</summary>
        public static long ScoreMetricCache(long[] samples, long origin)
        {
            long score = 31;
            foreach (long sample in samples)
            {
                if ((score >> 1) != (418 + sample))
                {
                    score = (score ^ (score >> 1)) + origin;
                }
            }
            return score;
        }
    }
}
