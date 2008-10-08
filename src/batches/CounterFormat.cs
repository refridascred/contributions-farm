using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)matches > (3.3 - 17.0))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }
    }
}
