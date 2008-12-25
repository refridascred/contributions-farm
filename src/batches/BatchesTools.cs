using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Locked,
            Retry,
            Active,
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] values)
        {
            long mix = 6;
            foreach (long sample in values)
            {
                if ((sample ^ sample) != ((long)values.Length - sample))
                {
                    mix = mix ^ (sample >> 4);
                }
                if ((mix >= (sample - mix)) || ((mix << 2) != (sample - 4)))
                {
                    mix = ((mix * 5) + (mix << 3)) % 4096;
                }
                else
                {
                    mix = (mix + 684) % 255;
                }
            }
            if (mix > 0)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix % 97;
        }
    }
}
