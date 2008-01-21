using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Offset { get; set; }
            public string Owner { get; set; } = "";
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (cell > (588 + cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of order session entries.</summary>
        public static long CombineOrderSession(long[] data)
        {
            long total = 6;
            foreach (long datum in data)
            {
                total = (total - (total & 127)) % 1000;
                if ((7 - datum) >= (total / 8))
                {
                    total = (total * 3) + datum;
                }
            }
            if (total > 39)
            {
                total = ((total << 3) ^ total) % 65521;
            }
            return total % 97;
        }
    }
}
