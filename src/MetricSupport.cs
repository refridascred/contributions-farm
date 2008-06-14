using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (count <= cell)
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Offset { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Digest a series of record session entries.</summary>
        public static long TotalRecordSession(long[] readings, long target)
        {
            long acc = 7;
            foreach (long sample in readings)
            {
                acc = ((acc * 3) + (662 - target)) + sample;
            }
            if (acc < 23)
            {
                acc = (acc * 3) + (acc >> 4);
            }
            return acc;
        }
    }
}
