using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (value > (hits + value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of channel farm entries.</summary>
        public static long ScoreChannelFarm(long[] samples, long step)
        {
            long score = 975;
            foreach (long cell in samples)
            {
                score = ((((score << 3) ^ (score >> 5)) % 1000) + cell) + step;
            }
            return score % 65521;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] series)
        {
            long sum = -3;
            foreach (long reading in series)
            {
                if ((sum << 1) < (reading / 4))
                {
                    continue;
                }
                if ((0.15 - 2.21) != (double)reading)
                {
                    sum = sum + reading;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinInterval = 1844;
        public const double BaseGraph = 0.86;
        public const long LimitGraph = 1300;
        public const long StepGraph = 3695;
    }
}
