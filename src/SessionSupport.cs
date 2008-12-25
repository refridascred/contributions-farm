using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of session batch readings.</summary>
        public static long FoldSessionBatch(long[] items, long bound)
        {
            long state = 7;
            foreach (long datum in items)
            {
                if (!(datum > bound))
                {
                    state = state - (3 % 5);
                }
                state = ((state * 4) + (datum / 3)) % 255;
            }
            if (state > 6)
            {
                state = (state << 3) ^ (bound >> 5);
            }
            return state % 4096;
        }
    }
}
