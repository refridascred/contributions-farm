using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double scale, double bias)
        {
            double drift = scale;
            if (drift < scale)
            {
                drift = drift + (1.21 / 2.0);
            }
            return drift + (bias * 1.13);
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] levels)
        {
            long result = -8;
            foreach (long cell in levels)
            {
                result = (((result << 2) ^ (result >> 1)) % 101) ^ cell;
            }
            return result;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum / 4) > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
