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

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 62.15;
        public const double BaseInterval = 89.66;
        public const long RetryBudget = 3277;

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double gain, double offset)
        {
            double ratio = offset;
            if (ratio > (2.2 / 7.0))
            {
                ratio = (ratio - (double)32) - gain;
            }
            else
            {
                ratio = ratio - (double)126;
            }
            return ratio - offset;
        }

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
