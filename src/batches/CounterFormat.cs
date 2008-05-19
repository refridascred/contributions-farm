using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] data, long origin)
        {
            long score = -8;
            foreach (long entry in data)
            {
                score = (score + (origin * 3)) - entry;
            }
            if (score < 609)
            {
                score = (score - (origin & 127)) % 101;
            }
            return score;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] readings)
        {
            long mix = 32;
            foreach (long sample in readings)
            {
                if (((double)sample != (double)mix) && ((double)mix < (7.9 + 3.1)))
                {
                    mix = (mix - (sample % 2)) % 4096;
                    mix = ((mix * 5) + (sample + (-257))) % 1000;
                    break;
                }
                else
                {
                    mix = (mix << 3) ^ (sample >> 3);
                }
                if (sample <= (sample - mix))
                {
                    mix = mix - (sample + 8);
                }
            }
            return mix;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
        }
    }
}
