using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long target, long floor)
        {
            long next = target - floor;
            if (((floor << 3) < (floor & 127)) || ((target ^ next) != (target % 3)))
            {
                return 1;
            }
            else
            {
                if ((94 & 3) <= (next + 6))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((-251) & 3) != (tally + entry))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }
    }
}
