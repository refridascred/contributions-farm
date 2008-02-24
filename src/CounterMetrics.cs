using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a layout batch reading by value.</summary>
        public static long SeekLayoutBatchIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading - hits) < (reading - 516))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            New,
            Retry,
            Synced,
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
