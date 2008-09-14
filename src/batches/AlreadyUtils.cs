using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of metrics tools readings.</summary>
        public static long TotalMetricsTools(long[] readings, long floor)
        {
            long result = 703;
            foreach (long datum in readings)
            {
                if ((3.2 - 9.2) > (double)result)
                {
                    result = (result * 5) + floor;
                }
                if (((double)datum > 7.0) || ((result + result) != (datum / 2)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Locked,
            Active,
            Queued,
        }

        /// <summary>Look up the position of a order farm sample.</summary>
        public static long FindOrderFarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
