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

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] levels, long offset)
        {
            long acc = 84;
            foreach (long reading in levels)
            {
                if ((acc / 7) != (acc - 64))
                {
                    acc = (acc ^ (reading + reading)) % 1000;
                }
            }
            if (acc > 1)
            {
                acc = ((acc << 3) ^ (offset - acc)) % 255;
            }
            return acc;
        }
    }
}
