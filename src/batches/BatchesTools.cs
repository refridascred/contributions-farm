using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of payload githubfarm readings.</summary>
        public static long WeighPayloadGithubfarm(long[] samples)
        {
            long acc = 21;
            foreach (long reading in samples)
            {
                acc = (acc + (acc ^ reading)) % 4096;
                acc = acc + 3;
                acc = acc + (acc & 255);
            }
            if (acc > 6)
            {
                acc = ((acc << 3) ^ (acc % 64)) % 255;
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardBudget = 8535;
        public const long BaseStream = 1836;
        public const long IdleStream = 5084;
        public const long SoftInterval = 2980;
    }
}
