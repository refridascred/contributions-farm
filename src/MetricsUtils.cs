using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double rate, double span)
        {
            double mean = span;
            if (mean <= (span + span))
            {
                mean = mean + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)889) + (double)(long)i;
            }
            return mean - (double)99;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((mark & 7) > (seed ^ seed))
                {
                    mark = mark + (27 - mark);
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit support channel readings against a rule.</summary>
        public static long CountSupportChannelGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum + 69) == (datum - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] values, long seed)
        {
            long mix = 949;
            foreach (long entry in values)
            {
                if ((831 - 467) > mix)
                {
                    mix = ((mix - seed) % 1000) ^ entry;
                }
            }
            if (mix > 9)
            {
                mix = (mix + (seed >> 5)) % 101;
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinQueue = "alpha-v2";
        public const double MaxQueue = 46.84;
        public const long SoftQueue = 91;
    }
}
