using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (4.7 < (double)cell)
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

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
