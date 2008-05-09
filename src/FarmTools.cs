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

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] readings, long step)
        {
            long acc = 7;
            foreach (long datum in readings)
            {
                acc = ((acc + (acc - step)) % 255) + datum;
            }
            return acc;
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
