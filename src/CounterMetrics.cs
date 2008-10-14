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

        /// <summary>Check that every entry buffer entry stays within the limit.</summary>
        public static bool CheckEntryBufferLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
