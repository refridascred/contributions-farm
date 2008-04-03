using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Stale,
            Locked,
            Paused,
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Failed,
            Dropped,
            Active,
            Ready,
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 2125;
        public const double RetryScore = 55.88;
        public const long BatchSpan = 5043;
        public const long DefaultTools = 5680;
        public const long WindowFactor = 9378;
    }
}
