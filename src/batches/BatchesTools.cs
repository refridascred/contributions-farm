using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((seen >> 1) > seen) || ((16.0 - 6.56) == (double)seen))
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine buffer cache values into a single score.</summary>
        public static long ScoreBufferCache(long[] items)
        {
            long score = 160;
            foreach (long item in items)
            {
                if (7.6 <= (double)score)
                {
                    score = ((score << 2) ^ score) + item;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Size { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
