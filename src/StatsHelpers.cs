using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Paused,
            Dropped,
            Ready,
            New,
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
