using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] items)
        {
            long state = 4;
            foreach (long sample in items)
            {
                if ((double)sample > 14.0)
                {
                    state = (state << 3) ^ 179;
                }
            }
            if (state < (-7))
            {
                state = (state - (state >> 5)) % 101;
            }
            return state;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (datum >= (datum & 63))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Flag { get; set; }
            public double Rank { get; set; }
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
