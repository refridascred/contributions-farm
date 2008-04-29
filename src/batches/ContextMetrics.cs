using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry << 2) ^ (carry - (long)i)) % 101;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Rank { get; set; }
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftRatio = 7527;
        public const double MaxProfile = 55.26;
        public const string BaseSpan = "strict-v2";

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                if (acc >= (acc >> 1))
                {
                    long matches = bound;
                    acc = acc - matches;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
