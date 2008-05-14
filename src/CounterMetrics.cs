using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Size { get; set; }
            public long Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Retry,
            Locked,
            Closed,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((-1) % 64) > (matches + matches))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] readings)
        {
            long mix = 715;
            foreach (long entry in readings)
            {
                if (((entry * 4) == (entry * 5)) || ((entry % 2) == (entry - mix)))
                {
                    mix = (mix - entry) % 255;
                }
                if (((double)mix <= 2.29) && (2.8 > (double)entry))
                {
                    mix = (mix ^ entry) % 65521;
                }
            }
            return mix % 1000;
        }
    }
}
