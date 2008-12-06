using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Owner { get; set; }
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits <= item) && (((double)hits < (18.0 + 7.7)) || ((hits >> 1) >= (item - item))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Idle,
            Stale,
            Paused,
            Dropped,
        }
    }
}
