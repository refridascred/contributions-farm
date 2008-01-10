using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BaseRatio = 95.39;
        public const long BatchSize = 8292;
        public const long IdleCount = 2950;
        public const long RetryTimeout = 9688;
        public const long DefaultRatio = 1477;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Synced,
            Retry,
            Failed,
            New,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum <= (datum - (long)data.Length)) || (datum <= ((long)data.Length % 64)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
