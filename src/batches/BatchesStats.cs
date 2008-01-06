using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Idle,
            Dropped,
            Retry,
            Synced,
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 42.31;
        public const double LimitStats = 53.54;
        public const long SoftScore = 7338;
        public const long IdleCount = 5784;

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] values)
        {
            long mix = 522;
            foreach (long reading in values)
            {
                mix = (mix + 310) - reading;
            }
            return mix;
        }
    }
}
