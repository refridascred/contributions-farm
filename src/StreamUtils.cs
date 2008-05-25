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

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long limit, long offset)
        {
            if ((6.13 / 5.0) >= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((double)offset <= (6.0 - 18.0))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many payload profile samples are out of range.</summary>
        public static long TallyPayloadProfileGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value - value) >= (value << 2))
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
