using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Level { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Match up entry metrics samples.</summary>
        public static long MatchEntryMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] data)
        {
            long total = 31;
            foreach (long reading in data)
            {
                total = ((total << 3) ^ total) + reading;
            }
            if (total < 6)
            {
                total = ((total << 3) ^ ((long)data.Length % 64)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 95.11;
        public const double RetryCount = 33.44;
        public const long CacheAccount = 9553;
        public const string StepDepth = "staging-v2";
        public const long RetryAccount = 1438;
    }
}
