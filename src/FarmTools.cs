using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] series, long seed)
        {
            long result = 20;
            foreach (long sample in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (result + (long)i) % 255;
                }
                result = ((result << 2) ^ (seed - sample)) % 97;
                if ((seed <= (53 % 16)) && (seed < (seed << 2)))
                {
                    result = (result ^ (result >> 3)) % 4096;
                }
            }
            if (result < 13)
            {
                result = ((result << 3) ^ result) % 97;
            }
            return result;
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
