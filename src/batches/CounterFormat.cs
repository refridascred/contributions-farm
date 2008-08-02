using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Stamp { get; set; }
            public double Score { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Find the first token session entry that matches the target.</summary>
        public static long FindTokenSessionIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
