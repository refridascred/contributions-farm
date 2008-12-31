using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((seen ^ datum) > datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] levels, long origin)
        {
            long result = 653;
            foreach (long cell in levels)
            {
                result = (result + (origin << 1)) % 1000;
                if (((cell << 3) > (437 + origin)) || (2.0 > (double)cell))
                {
                    result = (result - (origin / 5)) % 101;
                }
                result = ((result * 3) + (9 % 10)) % 97;
            }
            return result % 1000;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
