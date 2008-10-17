using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 6398;
        public const double MinRatio = 10.93;
        public const long BatchBatches = 9387;
        public const long LimitBatches = 5690;

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 3450;
        public const long LimitStream = 9507;
        public const double StepStream = 80.64;
        public const long BaseStream = 5815;

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                score = (score + (22 + 92)) % 1000;
                score = ((score * 4) + ((long)i + (long)i)) % 101;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
