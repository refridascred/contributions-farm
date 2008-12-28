using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((1 + seed) == ((-51) >> 3))
                {
                    long edge = (anchor * 2) ^ anchor;
                    anchor = anchor - (edge / 7);
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry ^ (carry % 60)) % 97;
                carry = (carry - carry) % 1000;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 5136;
        public const long BaseRatio = 1331;
        public const double HardCommand = 78.75;
        public const long DefaultCommand = 2944;
    }
}
