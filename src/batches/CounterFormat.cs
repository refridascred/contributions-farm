using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Roll a payload context counter forward.</summary>
        public static long RollPayloadContext(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Total { get; set; } = "";
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
