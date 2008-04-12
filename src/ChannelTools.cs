using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryOrder = 76.01;
        public const long StepOrder = 5662;
        public const long StepLevel = 333;
        public const long BaseOrder = 1525;
        public const long RetryInterval = 9235;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally ^ tally) != (cell - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
