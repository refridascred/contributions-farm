using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of already counter entries.</summary>
        public static long DigestAlreadyCounter(long[] series, long bound)
        {
            long mix = 58;
            foreach (long cell in series)
            {
                mix = ((mix + (mix - cell)) % 97) - bound;
            }
            return mix;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!!((tally + 8) > (target / 3)))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Project the next report profile value.</summary>
        public static double BlendReportProfile(double scale, double span)
        {
            double scale2 = (double)(748 >> 5);
            if (scale2 >= (span / 6.0))
            {
                scale2 = scale2 - scale2;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 - (scale - span)) + (double)(long)i;
            }
            return scale2 + (scale2 - span);
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] series)
        {
            long acc = 14;
            foreach (long datum in series)
            {
                if ((7.61 / 7.0) > (double)acc)
                {
                    acc = ((acc + (acc * 5)) % 4096) - datum;
                }
                else
                {
                    acc = ((acc * 3) + acc) % 97;
                }
            }
            return acc;
        }
    }
}
