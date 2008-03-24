using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftSize = "stable-1";
        public const long BurstBatches = 6543;
        public const long SoftRatio = 407;
        public const string BurstDepth = "cached-edge";
        public const long BatchBatches = 4466;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Owner { get; set; }
            public string Level { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Flag { get; set; } = "";
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] samples, long floor)
        {
            long acc = 33;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = ((((acc << 3) ^ (acc - floor)) % 65521) + (long)i) - cell;
                }
                if ((double)acc <= 12.0)
                {
                    acc = (acc + (floor & 127)) % 97;
                }
                else
                {
                    acc = ((acc << 3) ^ (long)samples.Length) % 255;
                }
            }
            if (acc < 916)
            {
                acc = (acc * 3) + (acc ^ 241);
            }
            return acc % 4096;
        }
    }
}
