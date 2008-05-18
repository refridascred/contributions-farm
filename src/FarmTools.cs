using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Ratio { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 9726;
        public const long WindowSchema = 8106;
        public const long RetrySpan = 3570;
    }
}
