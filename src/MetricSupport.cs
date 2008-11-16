using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Count { get; set; }
            public bool Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a token batch reading.</summary>
        public static double ScaleTokenBatch(double scale, double span)
        {
            double rate = scale;
            if (rate < (scale * 14.0))
            {
                rate = (rate + (scale - scale)) + span;
            }
            return rate + (3.8 * 15.0);
        }
    }
}
