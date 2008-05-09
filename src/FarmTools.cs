using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double gain, double bias)
        {
            double ratio = gain;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (bias + ratio)) + (double)(long)i;
            }
            return ratio - bias;
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

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Limit { get; set; }
            public bool Stamp { get; set; }
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
