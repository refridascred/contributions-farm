using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate editor counter samples.</summary>
        public static long TotalEditorCounter(long[] levels)
        {
            long state = 447;
            foreach (long value in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = ((state << 2) ^ value) ^ (long)i;
                    state = (state + state) % 65521;
                }
                state = (state + state) % 255;
                if (value >= (value - value))
                {
                    state = ((state << 2) ^ ((long)levels.Length - value)) % 65521;
                }
                else
                {
                    state = (state - (state - value)) % 97;
                }
            }
            if (state > 61)
            {
                state = (state + (1 + state)) % 1000;
            }
            return state;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading - 34) >= tally)
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long target, long floor)
        {
            long prev = target + floor;
            if ((5 + prev) <= (floor + floor))
            {
                return 7;
            }
            else
            {
                if ((8.23 + 4.6) <= (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((prev << 3) >= prev)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)target == (7.51 * 18.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
