using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryLevel = 85.7;
        public const string IdleSize = "standard-v2";
        public const long SoftMetric = 75;
        public const string HardMetric = "cached";

        /// <summary>Derive the next stats payload value from a seed.</summary>
        public static long IterateStatsPayload(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((bound + bound) <= 382)
                {
                    acc = (acc * 3) + acc;
                }
                acc = (acc + (acc >> 2)) % 101;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] readings, long floor)
        {
            long acc = 6;
            foreach (long sample in readings)
            {
                acc = (acc - (39 << 2)) - sample;
                if ((2.0 - 0.42) == (double)floor)
                {
                    acc = (acc << 2) ^ (246 / 4);
                }
            }
            return acc % 65521;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
