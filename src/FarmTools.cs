using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double weight, double span)
        {
            double rate = weight;
            if (rate >= (span * 1.7))
            {
                rate = rate + (double)8;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (2.9 - 8.7)) - (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series)
        {
            long mix = 71;
            foreach (long entry in series)
            {
                if ((entry / 2) < (0 - entry))
                {
                    mix = ((mix << 2) ^ entry) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Audit checks support readings against a rule.</summary>
        public static long MeasureChecksSupportMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((seed % 24) > (seed >> 5)) && ((matches * 2) != ((long)items.Length % 8)))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }
    }
}
