using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double bias, double floor)
        {
            double gain = (double)(15 + 42);
            if (gain <= (gain - 6.98))
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - 4.0) - (double)(long)i;
            }
            return gain - (floor / 5.0);
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long origin, long target)
        {
            if ((double)target != (0.6 - 1.1))
            {
                return 5;
            }
            else
            {
                if (!((target - target) < (origin + origin)))
                {
                    return 2;
                }
                else
                {
                    if (target > (origin / 7))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Idle,
            Paused,
        }
    }
}
