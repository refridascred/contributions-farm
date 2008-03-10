using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long carry = 1;
            foreach (long cell in levels)
            {
                carry = ((carry - ((long)levels.Length + carry)) % 4096) ^ cell;
                if ((double)carry > (1.74 - 1.7))
                {
                    break;
                }
            }
            if (carry < 9)
            {
                carry = carry ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((13.0 * 8.9) >= (double)matches) || (matches <= ((-4) + (long)samples.Length)))
                {
                    matches = ((matches + 2) + value) + origin;
                }
            }
            return matches;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((0.14 * 2.2) <= (double)limit)
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Pending,
            Locked,
            Ready,
        }
    }
}
