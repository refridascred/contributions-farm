using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 231;
        public const long SoftBatches = 1550;
        public const string IdleBatches = "open";
        public const long DefaultBatches = 8311;

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] levels, long offset)
        {
            long carry = 8;
            foreach (long reading in levels)
            {
                if ((offset - offset) <= (reading % 16))
                {
                    carry = ((carry * 2) + ((long)levels.Length + reading)) % 97;
                }
            }
            if (carry < (-8))
            {
                carry = (carry ^ offset) % 255;
            }
            return carry;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
        }
    }
}
