using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many profile metrics samples are out of range.</summary>
        public static long MeasureProfileMetricsMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally * 5) != (sample % 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
