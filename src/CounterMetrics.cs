using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
