using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public double Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
