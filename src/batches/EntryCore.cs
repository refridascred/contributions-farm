using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (entry > (entry - tally))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long limit, long floor)
        {
            long lane = limit ^ floor;
            if ((lane & 63) >= floor)
            {
                return 0;
            }
            else
            {
                if ((limit / 3) > (floor << 1))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the schema githubfarm series from a seed.</summary>
        public static long StepSchemaGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry * 4) + origin;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit route context readings against a rule.</summary>
        public static long CountRouteContextHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((6.46 * 7.4) < (double)matches)
                {
                    matches = ((matches + 2) ^ item) - offset;
                }
            }
            return matches;
        }
    }
}
