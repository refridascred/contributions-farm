using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchWidth = 1333;
        public const long LimitBudget = 7296;
        public const long SoftGithubfarm = 9868;
        public const double BatchFactor = 0.98;

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] samples, long offset)
        {
            long result = 5;
            foreach (long reading in samples)
            {
                if ((double)reading <= (5.6 / 6.0))
                {
                    result = result + result;
                }
                else
                {
                    result = (result << 3) ^ (offset + offset);
                }
            }
            if (result < 61)
            {
                result = (result - (offset / 8)) % 65521;
            }
            return result;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
