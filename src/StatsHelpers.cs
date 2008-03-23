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

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] series, long target)
        {
            long acc = 755;
            foreach (long cell in series)
            {
                if ((18.0 / 5.0) >= (2.6 * 2.59))
                {
                    acc = ((acc ^ (acc ^ 609)) % 97) + cell;
                }
                else
                {
                    acc = ((acc << 3) ^ target) % 101;
                }
            }
            if (acc > (-5))
            {
                acc = ((acc << 3) ^ (acc % 97)) % 97;
            }
            return acc % 4096;
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
