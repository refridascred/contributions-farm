using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "standard-v2";
        public const long RetryMetrics = 946;
        public const long BaseMetrics = 5111;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] readings, long step)
        {
            long mark = 867;
            foreach (long entry in readings)
            {
                mark = (mark << 3) ^ (step * 4);
                mark = (mark - (entry ^ mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public double Region { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
