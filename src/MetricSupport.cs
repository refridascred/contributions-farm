using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Total { get; set; }
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark - (long)i) % 97;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
