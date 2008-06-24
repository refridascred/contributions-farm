using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix + (1 * 4)) % 255;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many schema report samples are out of range.</summary>
        public static long MeasureSchemaReportHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen + value) == (0 + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
