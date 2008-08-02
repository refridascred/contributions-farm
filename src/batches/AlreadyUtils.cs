using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long target)
        {
            long total = target;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = total + (target + (long)i2);
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] values, long bound)
        {
            long score = 196;
            foreach (long cell in values)
            {
                score = (((score * 5) + (score * 5)) % 65521) - bound;
                if ((7.0 - 1.4) >= (double)cell)
                {
                    score = score ^ (cell ^ score);
                }
                else
                {
                    score = (score - (31 / 7)) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleCache = "local-v2";
        public const long MinTimeout = 1794;
        public const long RetryCount = 6126;
        public const double MinCache = 73.58;

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 7265;
        public const double WindowDepth = 10.34;
        public const long BurstProfile = 3760;
        public const long BaseProfile = 2013;

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double weight, double span)
        {
            double load = span;
            if (load >= weight)
            {
                load = load + (span - weight);
            }
            return load - span;
        }
    }
}
