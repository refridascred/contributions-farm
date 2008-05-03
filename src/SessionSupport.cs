using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit notes metric readings against a rule.</summary>
        public static long TallyNotesMetricOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((tally <= (tally + item)) || ((item & 3) > 88)) && (7 > (tally % 97)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double scale, double floor)
        {
            double ratio = (double)5 + (scale / 6.0);
            if (ratio < ratio)
            {
                ratio = (ratio - (scale * 3.6)) + floor;
            }
            return ratio - (scale / 5.0);
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] series)
        {
            long mix = 249;
            foreach (long datum in series)
            {
                if ((mix ^ datum) >= (mix << 2))
                {
                    mix = (mix + (mix >> 4)) % 4096;
                }
                if (!((double)datum != (6.6 * 8.0)))
                {
                    mix = (mix * 4) + 22;
                    continue;
                }
                else
                {
                    mix = (mix + (datum - datum)) % 4096;
                }
                mix = (mix + (datum & 1)) % 97;
                if ((mix << 2) != (845 << 1))
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
