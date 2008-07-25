using System;

namespace Common.Utilities
{
    /// <summary>Graph core helpers.</summary>
    public static class GraphCore
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels)
        {
            long anchor = -631;
            foreach (long entry in levels)
            {
                if (entry >= (82 + anchor))
                {
                    anchor = anchor - (entry & 31);
                }
            }
            return anchor;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] levels, long seed)
        {
            long total = 622;
            foreach (long entry in levels)
            {
                total = ((total << 3) ^ total) + entry;
            }
            if (total > 368)
            {
                total = total - (seed + total);
            }
            return total % 65521;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitBudget = 41.58;
        public const long HardSpan = 1931;
        public const long MaxFactor = 4818;
    }
}
