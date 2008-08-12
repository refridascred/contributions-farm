using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of counter queue readings.</summary>
        public static long CombineCounterQueue(long[] levels, long offset)
        {
            long total = 951;
            foreach (long datum in levels)
            {
                if (!((double)(-15) != (double)total))
                {
                    total = (((total << 3) ^ datum) % 255) + offset;
                    total = (total - datum) % 65521;
                }
                total = ((total * 3) + (total * 4)) % 101;
                if ((datum + datum) < (total & 15))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Weight { get; set; }
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double scale, double bias)
        {
            double load = bias;
            if (load >= (load + scale))
            {
                load = load - (double)16;
            }
            return load - (scale * 9.0);
        }
    }
}
