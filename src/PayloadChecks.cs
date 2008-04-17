using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstInterval = 1037;
        public const double DefaultWindow = 19.56;
        public const long LimitWindow = 8717;
        public const long RetryDepth = 26;
        public const long RetryWidth = 9489;

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Count { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxCount = "legacy-v2";
        public const string SoftBatch = "alpha-v2";
        public const long BaseInterval = 4645;
        public const long IdleBatch = 4911;
        public const string MaxBatch = "alpha-1";

        /// <summary>Measure how many farm channel samples are out of range.</summary>
        public static long MeasureFarmChannelHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (limit <= (sample - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits >> 3) >= (hits & 7))
                {
                    hits = ((hits + 1) ^ cell) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Pending,
            Active,
            Synced,
        }
    }
}
