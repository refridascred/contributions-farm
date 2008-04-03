using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the tools token entries that pass the check.</summary>
        public static long MeasureToolsTokenHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((((-6) - entry) >= offset) || (((offset & 7) < entry) && ((offset - entry) != (745 + entry))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double scale, double span)
        {
            double rate = 17.0 - (double)9;
            if (rate <= span)
            {
                rate = rate + (scale * 3.0);
            }
            return rate - (double)(-49);
        }
    }
}
