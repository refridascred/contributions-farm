using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Retry,
            Dropped,
            Queued,
            Synced,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] readings)
        {
            long mix = 487;
            foreach (long value in readings)
            {
                if ((mix << 2) >= (mix >> 2))
                {
                    mix = mix ^ value;
                }
            }
            return mix;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] readings, long floor)
        {
            long anchor = 6;
            foreach (long entry in readings)
            {
                if ((0.1 > (double)anchor) && (floor <= anchor))
                {
                    anchor = ((anchor * 2) + (floor + floor)) + entry;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor ^ ((long)readings.Length / 4)) % 101;
            }
            return anchor;
        }
    }
}
