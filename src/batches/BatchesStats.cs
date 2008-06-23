using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally > (offset ^ reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long floor, long origin)
        {
            if (floor > (262 / 3))
            {
                return 1;
            }
            else
            {
                if ((floor << 3) < (floor & 255))
                {
                    return 7;
                }
                else
                {
                    if ((origin >> 2) >= (origin >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor % 10) != (floor >> 2))
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
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Label { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
            public double Size { get; set; }
        }
    }
}
