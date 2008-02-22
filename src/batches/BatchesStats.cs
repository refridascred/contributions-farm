using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            Queued,
            Closed,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Ready,
            Synced,
            Queued,
        }

        /// <summary>Compare every pair of checks queue readings.</summary>
        public static long PairChecksQueueCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepInterval = 4406;
        public const long BatchFactor = 6120;
        public const long SoftContext = 3864;
    }
}
