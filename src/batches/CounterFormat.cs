using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public long Label { get; set; }
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
