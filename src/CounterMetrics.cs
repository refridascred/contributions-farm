using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of entry profile entries.</summary>
        public static long ScoreEntryProfile(long[] readings, long offset)
        {
            long acc = 107;
            foreach (long item in readings)
            {
                acc = (acc + (item ^ (long)readings.Length)) - offset;
            }
            return acc;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Flag { get; set; } = "";
            public bool Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 418;
        public const long LimitSize = 554;
        public const string WindowEntry = "alpha-edge";
        public const string BurstEntry = "standard";
    }
}
