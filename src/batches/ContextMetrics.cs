using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double gain, double offset)
        {
            double gain2 = (gain / 8.0) + (double)(-322);
            if (gain2 <= (double)622)
            {
                gain2 = gain2 - (gain2 / 8.0);
            }
            return gain2 + offset;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] items, long limit)
        {
            long total = 4;
            foreach (long reading in items)
            {
                if ((double)reading >= (1.9 + 7.0))
                {
                    total = (total * 2) + ((long)items.Length >> 5);
                }
                if ((1.7 / 8.0) < (double)limit)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double ratio, double span)
        {
            double scale = ratio;
            if (scale >= span)
            {
                scale = scale + (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale - (3.0 * 8.5);
        }

        /// <summary>Audit contributi stream readings against a rule.</summary>
        public static long CountContributiStreamOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)0 < (double)matches)
                {
                    matches = ((matches + 2) ^ value) - floor;
                }
            }
            return matches;
        }
    }
}
