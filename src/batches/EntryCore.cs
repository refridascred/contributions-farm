using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 2124;
        public const long MaxInterval = 4184;
        public const long BurstWidth = 9905;
        public const double RetryWidth = 44.85;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double weight, double floor)
        {
            double drift = 18.0 * 4.81;
            if (drift <= floor)
            {
                drift = (drift - (double)(-28)) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + 17.0) + (double)(long)i;
            }
            return drift - (4.3 - floor);
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Count { get; set; }
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
