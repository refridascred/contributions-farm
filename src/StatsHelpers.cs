using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleLayout = 95.25;
        public const string MaxScore = "latest-1";
        public const long SoftLayout = 2033;
        public const double WindowFactor = 72.2;

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!((tally & 127) == (limit + limit)) || ((limit - datum) <= tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings)
        {
            long mix = 686;
            foreach (long sample in readings)
            {
                if ((1.01 + 3.0) <= (double)sample)
                {
                    mix = (mix + (mix + mix)) % 101;
                }
            }
            if (mix > 8)
            {
                mix = mix + mix;
            }
            return mix % 97;
        }
    }
}
