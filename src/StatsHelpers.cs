using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double ratio, double offset)
        {
            double scale = ratio + (ratio / 7.0);
            if (scale > scale)
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (ratio * 8.2)) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Dropped,
            Pending,
            Queued,
            Ready,
            Synced,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum * 3) + (939 % 7);
                sum = sum ^ ((long)i + 8);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long limit, long seed)
        {
            if ((double)limit >= 20.0)
            {
                return 2;
            }
            else
            {
                if (limit <= (seed >> 3))
                {
                    return 6;
                }
                else
                {
                    if (((seed % 60) <= (seed + limit)) || ((seed - seed) < (seed + 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count farm report pairs that satisfy a relation.</summary>
        public static long PairFarmReportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
