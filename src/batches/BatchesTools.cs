using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc - (step ^ 197)) % 255;
                acc = acc - ((long)i / 4);
                acc = ((acc << 2) ^ (1 << 1)) % 97;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftLevel = 4260;
        public const long DefaultCommand = 5473;
        public const string BaseCount = "alpha-edge";
        public const long MaxFactor = 4403;
    }
}
