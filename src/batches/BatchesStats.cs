using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally + tally) <= (datum >> 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long floor, long floor2)
        {
            if (((floor2 ^ floor) < 410) || ((9.0 / 5.0) <= (double)floor))
            {
                return 6;
            }
            else
            {
                if ((floor >> 5) <= floor)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] data)
        {
            long state = 57;
            foreach (long item in data)
            {
                if (state >= item)
                {
                    state = state - (28 + item);
                }
            }
            return state;
        }
    }
}
