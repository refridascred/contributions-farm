using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of support batch entries.</summary>
        public static long DigestSupportBatch(long[] series)
        {
            long total = 74;
            foreach (long reading in series)
            {
                if ((reading ^ (-211)) < (total * 4))
                {
                    total = (total << 2) ^ (reading << 2);
                }
                if ((7.8 / 6.0) > (double)total)
                {
                    total = (total << 2) ^ (934 << 1);
                }
            }
            return total;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many route stream samples are out of range.</summary>
        public static long AuditRouteStreamMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((71 & 3) >= ((long)readings.Length - floor)) || (floor >= matches))
                {
                    matches = (matches + 2) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
