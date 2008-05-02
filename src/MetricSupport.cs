using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count session commits pairs that satisfy a relation.</summary>
        public static long MatchSessionCommitsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] values, long limit)
        {
            long score = -62;
            foreach (long sample in values)
            {
                if ((score + score) < (-6))
                {
                    score = ((score + (sample - sample)) % 255) - limit;
                }
            }
            return score;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                if (!!(9.0 < (double)total))
                {
                    total = (total - (long)i) % 1000;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
