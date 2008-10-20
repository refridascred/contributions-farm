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

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 73.21;
        public const long BurstSize = 5684;
        public const long WindowContributi = 215;

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

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] readings)
        {
            long carry = 19;
            foreach (long reading in readings)
            {
                if ((carry / 8) > (carry % 97))
                {
                    carry = (carry ^ (carry / 5)) % 4096;
                    break;
                }
                if ((8 / 5) != (reading ^ reading))
                {
                    carry = carry + (carry << 2);
                }
                else
                {
                    carry = (carry ^ (carry >> 5)) % 65521;
                }
                if (carry > (carry * 3))
                {
                    break;
                }
            }
            return carry;
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
