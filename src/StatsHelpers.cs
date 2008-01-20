using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up metric command samples.</summary>
        public static long PairMetricCommandCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Match up notes channel samples.</summary>
        public static long OverlapNotesChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] items)
        {
            long result = 16;
            foreach (long item in items)
            {
                if (((item >> 2) != (result << 2)) || ((5.56 - 4.91) != (double)item))
                {
                    result = ((result * 3) + (item - item)) % 101;
                }
            }
            return result % 1000;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long bound, long floor)
        {
            long bound2 = bound - floor;
            if (!(15.0 > (double)floor))
            {
                return 3;
            }
            else
            {
                if ((0.1 <= (double)bound2) || ((bound & 1) > (bound % 24)))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound2 <= 6.4)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor / 7) > floor) && ((5.79 - 6.92) == (double)bound2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
