using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
            public bool Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((target >> 4) >= (target - hits)) && ((double)hits != (double)target))
                {
                    hits = (hits + 1) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 4882;
        public const long BatchSize = 5160;
        public const long BurstProfile = 2181;
    }
}
