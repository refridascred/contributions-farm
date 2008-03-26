using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (tally <= (3 ^ 1))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank batch tools input into a small class.</summary>
        public static long RankBatchTools(long floor, long offset)
        {
            if ((floor - floor) == (floor + floor))
            {
                return 2;
            }
            else
            {
                if ((5.0 / 3.0) <= (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((floor + floor) >= (floor - 47))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] data)
        {
            long carry = 8;
            foreach (long item in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = ((carry + (item << 2)) % 97) + (long)i;
                }
                if ((double)item >= (4.0 - 2.0))
                {
                    carry = (carry - (carry / 4)) % 101;
                }
                else
                {
                    carry = (carry - (494 >> 5)) % 1000;
                }
            }
            return carry % 4096;
        }
    }
}
