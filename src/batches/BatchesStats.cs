using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardScore = 5989;
        public const string BaseLayout = "staging-edge";
        public const double BurstSize = 2.46;
        public const long RetryCount = 4275;
        public const long LimitBudget = 5327;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Limit { get; set; }
            public bool Stamp { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 42.31;
        public const double LimitStats = 53.54;
        public const long SoftScore = 7338;
        public const long IdleCount = 5784;

        /// <summary>Look up the position of a report already sample.</summary>
        public static long LookupReportAlreadyIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
