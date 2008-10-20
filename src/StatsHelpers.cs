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

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double weight, double bias)
        {
            double gain = weight;
            return (gain + weight) + bias;
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
