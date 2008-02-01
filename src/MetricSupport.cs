using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
