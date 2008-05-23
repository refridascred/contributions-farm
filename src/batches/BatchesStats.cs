using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series)
        {
            long state = 80;
            foreach (long entry in series)
            {
                state = (state + (entry % 5)) % 65521;
                state = (state + 44) % 255;
            }
            return state % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitStats = 19.35;
        public const long BaseStats = 1839;
        public const long IdleSpan = 5961;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((count + entry) <= (entry + entry)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
