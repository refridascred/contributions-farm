using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitCount = 9827;
        public const string IdleScore = "latest-1";
        public const long MaxRatio = 652;

        /// <summary>Fold a list of route tools readings.</summary>
        public static long WeighRouteTools(long[] samples, long offset)
        {
            long mark = 87;
            foreach (long sample in samples)
            {
                mark = (mark ^ ((long)samples.Length + offset)) ^ sample;
            }
            return mark;
        }
    }
}
