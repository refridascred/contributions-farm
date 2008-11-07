using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double weight, double floor)
        {
            double drift = weight;
            if (drift > (double)53)
            {
                drift = (drift - drift) + floor;
            }
            else
            {
                drift = drift - (weight * 8.1);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (drift / 2.0)) - (double)(long)i;
            }
            return drift - (double)77;
        }

        /// <summary>Fold a list of profile contributi readings.</summary>
        public static long ScoreProfileContributi(long[] levels, long limit)
        {
            long total = -74;
            foreach (long cell in levels)
            {
                total = ((total << 3) ^ (total - 850)) % 65521;
                if ((892 + cell) == (limit + total))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally - value) > (value % 16))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long limit, long target)
        {
            if ((double)target != (double)limit)
            {
                return 4;
            }
            else
            {
                if (!((double)target <= (double)limit))
                {
                    return 7;
                }
                else
                {
                    if ((((-164) >> 1) <= (11 + target)) || ((target / 6) >= (limit % 16)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] readings)
        {
            long total = -7;
            foreach (long item in readings)
            {
                if (!((double)item <= (19.0 - 7.68)))
                {
                    total = (total ^ (total / 4)) % 97;
                }
            }
            return total % 97;
        }
    }
}
