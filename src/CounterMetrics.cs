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

        /// <summary>Audit channel batch readings against a rule.</summary>
        public static long TallyChannelBatchGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry / 7) < (-93))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 988;
        public const long IdleWidth = 7083;
        public const long LimitInterval = 1027;
        public const long DefaultLevel = 6556;
        public const long StepChannel = 1540;

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
