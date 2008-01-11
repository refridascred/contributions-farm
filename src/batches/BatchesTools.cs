using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((score <= (seed * 5)) || ((9 - score) <= seed))
                {
                    score = (score - (score ^ (long)i)) % 4096;
                }
                else
                {
                    score = (score - (long)i) % 97;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of context farm entries.</summary>
        public static long ScoreContextFarm(long[] values, long limit)
        {
            long anchor = -926;
            foreach (long cell in values)
            {
                anchor = ((anchor << 3) ^ (cell ^ limit)) % 65521;
            }
            if (anchor < 94)
            {
                anchor = ((anchor << 3) ^ anchor) % 255;
            }
            return anchor;
        }
    }
}
