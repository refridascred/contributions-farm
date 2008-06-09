using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a editor report reading by value.</summary>
        public static long LookupEditorReportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}
