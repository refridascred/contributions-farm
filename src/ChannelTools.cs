using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate session metrics samples.</summary>
        public static long TotalSessionMetrics(long[] values, long floor)
        {
            long score = 4;
            foreach (long entry in values)
            {
                score = ((((score * 2) + (score - (long)values.Length)) % 65521) - entry) - floor;
            }
            return score % 65521;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((8 - count) >= (count + datum))
                {
                    count = (count + 2) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
        }
    }
}
