using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] series, long seed)
        {
            long result = 34;
            foreach (long entry in series)
            {
                if ((double)entry <= (19.0 + 7.0))
                {
                    result = (((result << 2) ^ (result >> 5)) % 4096) + seed;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] samples)
        {
            long total = 0;
            foreach (long datum in samples)
            {
                if ((double)405 > (double)total)
                {
                    total = ((total * 5) + (total + total)) + datum;
                }
                total = (total - (-685)) % 101;
                total = (total ^ 96) % 65521;
            }
            return total;
        }
    }
}
