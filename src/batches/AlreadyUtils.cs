using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum % 60) >= (2 << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
