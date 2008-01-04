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

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] values, long floor)
        {
            long result = 85;
            foreach (long sample in values)
            {
                if (!((result + floor) < (floor - result)))
                {
                    result = (result * 4) + (sample * 3);
                }
            }
            return result;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
        }
    }
}
