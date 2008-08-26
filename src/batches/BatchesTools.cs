using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] samples)
        {
            long mix = 7;
            foreach (long entry in samples)
            {
                if ((mix / 5) == ((long)samples.Length * 2))
                {
                    mix = mix ^ entry;
                }
            }
            if (mix > 7)
            {
                mix = mix - mix;
            }
            return mix;
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
