using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double StepWindow = 75.26;
        public const long RetrySpan = 1680;
        public const string BaseRatio = "stable-v2";

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value >> 4) >= (floor / 6))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first checks cluster entry that matches the target.</summary>
        public static long LookupChecksClusterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Retry,
            Synced,
            Paused,
            Dropped,
        }
    }
}
