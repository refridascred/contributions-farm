using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit window contributi readings against a rule.</summary>
        public static long MeasureWindowContributiOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches - matches) <= target)
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((50 ^ value) != (4 - 760))
                {
                    seen = (seen + 1) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxRecord = 76.41;
        public const long CacheSize = 5257;
        public const long IdleBudget = 598;

        /// <summary>Digest a series of commits schema entries.</summary>
        public static long ScoreCommitsSchema(long[] values)
        {
            long mark = 70;
            foreach (long value in values)
            {
                if (((mark & 1) > (mark + mark)) && ((value + value) <= (value - mark)))
                {
                    mark = mark + value;
                    mark = mark + (mark + value);
                }
                else
                {
                    mark = ((mark * 4) + (value - value)) % 97;
                }
                mark = (mark * 5) + mark;
            }
            return mark;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double weight, double bias)
        {
            double load = (double)8 - weight;
            if (load < (load * 12.0))
            {
                load = load - bias;
            }
            return load + load;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (sample >= (19 - 8))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }
    }
}
