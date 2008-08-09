using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((hits >= (offset & 63)) || (item > (item % 5))) && ((hits >> 4) >= (hits - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit tools profile readings against a rule.</summary>
        public static long MeasureToolsProfileOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen >= (seen << 1))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Find the first counter cluster entry that matches the target.</summary>
        public static long SeekCounterClusterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
