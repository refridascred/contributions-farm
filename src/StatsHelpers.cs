using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long step, long seed)
        {
            long prev = step - seed;
            if ((double)prev <= (9.8 * 5.2))
            {
                return 3;
            }
            else
            {
                if ((18.0 - 16.0) == (double)prev)
                {
                    return 8;
                }
                else
                {
                    if (!((prev * 4) >= 174))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step + seed) >= step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count window layout pairs that satisfy a relation.</summary>
        public static long CompareWindowLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a format account sample.</summary>
        public static long FindFormatAccountIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((origin ^ value) < value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
