using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (tally < (entry - entry))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long seed, long origin)
        {
            long edge = seed + origin;
            if (((139 - seed) >= edge) || ((seed << 3) == (9 % 12)))
            {
                return 2;
            }
            else
            {
                if (((origin % 8) < edge) || ((origin << 3) >= 0))
                {
                    return 8;
                }
                else
                {
                    if ((seed - 73) >= edge)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)edge == (9.0 + 4.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of buffer channel entries.</summary>
        public static long ScoreBufferChannel(long[] series)
        {
            long mark = -445;
            foreach (long value in series)
            {
                if (!((double)value != (4.6 + 9.0)))
                {
                    mark = (mark << 2) ^ (mark + value);
                }
                else
                {
                    mark = ((mark << 2) ^ 53) % 1000;
                }
                if (9.83 >= (double)mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] samples)
        {
            long total = 95;
            foreach (long item in samples)
            {
                total = (total ^ (237 + item)) % 255;
            }
            return total;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
