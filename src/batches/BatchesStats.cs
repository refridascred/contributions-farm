using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BurstSize = "fallback";
        public const long BurstSpan = 5170;
        public const string WindowLevel = "local-edge";
        public const double LimitSupport = 74.56;

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                if ((double)score == (double)715)
                {
                    score = (score * 3) + (score - score);
                    score = score + score;
                }
                score = (score << 2) ^ (766 & 63);
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] levels)
        {
            long mark = -2;
            foreach (long sample in levels)
            {
                if ((mark + sample) > mark)
                {
                    mark = (mark << 3) ^ (82 - mark);
                }
            }
            return mark % 65521;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
