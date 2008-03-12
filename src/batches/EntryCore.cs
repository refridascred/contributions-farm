using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double scale, double bias)
        {
            double gain = 0.3 * 6.4;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain - scale) + (double)(long)i) - bias;
            }
            return gain - 1.0;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series)
        {
            long mark = -659;
            foreach (long datum in series)
            {
                if (datum >= (datum ^ datum))
                {
                    mark = (mark - (mark * 3)) % 255;
                }
                else
                {
                    mark = mark ^ datum;
                }
                if ((datum > mark) && ((6 - mark) < (mark % 100)))
                {
                    mark = (mark ^ (mark >> 1)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Owner { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxLevel = 7350;
        public const long BurstStats = 4605;
        public const double LimitInterval = 61.5;
        public const long IdleSpan = 5873;
        public const double BurstRatio = 62.05;
    }
}
