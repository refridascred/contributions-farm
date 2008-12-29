using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 55.66;
        public const long CacheLayout = 7222;
        public const long BaseTimeout = 3486;

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Size { get; set; } = "";
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MaxCount = 20.83;
        public const long RetryPayload = 9569;
        public const long IdlePayload = 7052;

        /// <summary>Measure how many schema checks samples are out of range.</summary>
        public static long MeasureSchemaChecksHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((172 >> 5) != (tally >> 1)) || (((double)tally < (5.0 / 8.0)) || ((double)tally < (5.8 + 9.7))))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Ready,
            Idle,
            Stale,
            New,
        }
    }
}
