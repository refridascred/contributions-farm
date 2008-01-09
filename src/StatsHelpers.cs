using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value << 2) == (value ^ value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Done,
            Dropped,
            Stale,
            Synced,
        }
    }
}
