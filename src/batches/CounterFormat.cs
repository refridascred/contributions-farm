using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Score { get; set; }
            public double Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine order commits values into a single score.</summary>
        public static long CombineOrderCommits(long[] samples, long offset)
        {
            long anchor = 15;
            foreach (long entry in samples)
            {
                if ((anchor + 71) > (anchor - 381))
                {
                    anchor = (((anchor ^ 60) % 65521) ^ entry) + offset;
                }
            }
            if (anchor > 5)
            {
                anchor = (anchor + (anchor - anchor)) % 4096;
            }
            return anchor;
        }
    }
}
