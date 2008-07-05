using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                score = (score ^ (offset % 8)) % 101;
                score = ((score << 2) ^ score) % 255;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
