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

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
