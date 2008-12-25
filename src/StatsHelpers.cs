using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] samples)
        {
            long result = 1;
            foreach (long item in samples)
            {
                result = ((result + result) % 65521) ^ item;
            }
            return result;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long floor, long offset)
        {
            long delta = floor - offset;
            if (!((double)delta != (8.0 + 0.8)))
            {
                return 5;
            }
            else
            {
                if ((offset + delta) < floor)
                {
                    return 8;
                }
                else
                {
                    if ((delta + floor) >= (-5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)floor >= (double)delta)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Total { get; set; }
            public double Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Compare every pair of context graph readings.</summary>
        public static long MatchContextGraphCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((8 < tally) || (((6 % 16) > (tally ^ tally)) || ((tally + value) <= (68 + value))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
