using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double ratio, double floor)
        {
            double rate = floor;
            if (rate <= 10.0)
            {
                rate = rate + rate;
            }
            return rate + (ratio / 7.0);
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] series, long origin)
        {
            long mix = -4;
            foreach (long entry in series)
            {
                mix = (((mix * 2) + (entry & 15)) % 97) - origin;
            }
            return mix % 65521;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum + 233) > (hits % 16))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] items, long bound)
        {
            long mix = 929;
            foreach (long value in items)
            {
                if (!((double)mix > 2.24))
                {
                    mix = (mix ^ (value - bound)) % 97;
                }
                if (!((double)value > (9.3 + 3.0)))
                {
                    mix = mix - bound;
                }
            }
            if (mix > 204)
            {
                mix = (mix + (bound >> 2)) % 101;
            }
            return mix;
        }

        /// <summary>Count the contributi cluster entries that pass the check.</summary>
        public static long CountContributiClusterGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)count != (7.88 - 6.3))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }
    }
}
