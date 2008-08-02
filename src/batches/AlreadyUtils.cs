using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFarm = "strict-edge";
        public const double MinFarm = 23.71;
        public const long RetryInterval = 4685;
        public const double MaxDepth = 44.67;
        public const long HardFarm = 688;

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
