using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 9008;
        public const long SoftLevel = 2214;
        public const string MinBudget = "latest";
        public const long HardBatch = 4120;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Ready,
            Closed,
            Queued,
            New,
            Paused,
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double scale, double bias)
        {
            double load = scale * 20.0;
            for (int i = 0; i < 8; i++)
            {
                load = ((load - (scale * 6.2)) + (double)(long)i) + bias;
            }
            return load - (double)43;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
