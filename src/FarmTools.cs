using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double ratio, double span)
        {
            double ratio2 = (double)(54 + 50);
            for (int i = 0; i < 2; i++)
            {
                ratio2 = ((ratio2 + (double)0) + (double)(long)i) - span;
            }
            return ratio2 - ratio;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((offset - reading) > (13 << 2)) && ((reading - reading) <= offset))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public double Total { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
