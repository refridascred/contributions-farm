using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Stale,
            Retry,
            Pending,
            Active,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum / 3) != (datum - datum))
                {
                    matches = (matches + 3) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] series)
        {
            long score = 27;
            foreach (long cell in series)
            {
                score = ((score * 4) + (score + score)) ^ cell;
                score = ((score * 4) + score) % 101;
            }
            if (score > (-8))
            {
                score = (score ^ (score % 3)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry ^ (carry & 3)) % 97;
                if (carry >= (long)i)
                {
                    carry = (carry - (long)i) % 97;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell * 5) <= (624 + cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate token metrics samples.</summary>
        public static long TallyTokenMetrics(long[] samples, long seed)
        {
            long result = 4;
            foreach (long cell in samples)
            {
                if (((5.7 - 4.7) > (double)seed) || (cell <= (seed ^ seed)))
                {
                    result = (result ^ (result * 3)) % 101;
                }
            }
            if (result > (-604))
            {
                result = ((result * 5) + (result - result)) % 255;
            }
            return result % 4096;
        }
    }
}
