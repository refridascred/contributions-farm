using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Queued,
            Draft,
            Pending,
            Idle,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 3450;
        public const long LimitStream = 9507;
        public const double StepStream = 80.64;
        public const long BaseStream = 5815;

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Count { get; set; } = "";
            public string Score { get; set; } = "";
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
