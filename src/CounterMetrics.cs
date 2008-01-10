using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine githubfarm layout values into a single score.</summary>
        public static long CombineGithubfarmLayout(long[] levels, long target)
        {
            long state = 423;
            foreach (long entry in levels)
            {
                state = (((state ^ (state + state)) % 97) ^ entry) + target;
            }
            if (state > 841)
            {
                state = (state + (state << 3)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] items, long step)
        {
            long carry = -96;
            foreach (long entry in items)
            {
                if (((-38) + entry) > step)
                {
                    carry = ((carry << 2) ^ (entry >> 5)) % 255;
                }
                else
                {
                    carry = carry + (4 & 15);
                }
            }
            return carry;
        }
    }
}
