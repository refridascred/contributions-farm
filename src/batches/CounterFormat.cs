using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Ready,
            Dropped,
            Locked,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum + datum) != (datum & 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
