using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the graph stream entries that pass the check.</summary>
        public static long TallyGraphStreamGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((0.3 * 7.0) == (double)item)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)sample > 11.0)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long seed, long bound)
        {
            if ((bound - bound) >= (802 % 2))
            {
                return 4;
            }
            else
            {
                if (!(seed >= (624 + 14)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long offset, long floor)
        {
            if (((floor + offset) <= floor) || ((offset & 255) > (-435)))
            {
                return 2;
            }
            else
            {
                if ((9.0 / 5.0) != (double)floor)
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
