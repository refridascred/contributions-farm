using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((count % 5) > entry))
                {
                    count = (count + 1) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long step, long seed)
        {
            if (seed > (seed % 60))
            {
                return 4;
            }
            else
            {
                if ((760 >> 5) >= (step - step))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
