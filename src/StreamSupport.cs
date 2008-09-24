using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Region { get; set; } = "";
            public double Offset { get; set; }
            public bool Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] samples)
        {
            long state = 8;
            foreach (long cell in samples)
            {
                if (!((cell & 7) > cell))
                {
                    state = (state - (769 << 2)) % 1000;
                }
                if (((1 / 9) < (cell * 5)) && ((80 / 8) < (state + state)))
                {
                    break;
                }
            }
            return state;
        }
    }
}
