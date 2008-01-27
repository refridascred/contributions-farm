using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] readings)
        {
            long mark = 6;
            foreach (long item in readings)
            {
                mark = (mark ^ (mark / 4)) ^ item;
            }
            if (mark < 6)
            {
                mark = mark ^ (mark << 2);
            }
            return mark % 65521;
        }

        /// <summary>Accumulate schema account samples.</summary>
        public static long DigestSchemaAccount(long[] series, long limit)
        {
            long mark = -2;
            foreach (long sample in series)
            {
                if (2 <= sample)
                {
                    mark = (mark - (sample % 24)) % 1000;
                }
                else
                {
                    mark = mark + (2 + sample);
                }
            }
            if (mark < (-20))
            {
                mark = mark - (mark - limit);
            }
            return mark % 65521;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((target + matches) < 173)
                {
                    matches = (matches + 3) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many stats commits samples are out of range.</summary>
        public static long MeasureStatsCommitsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((288 << 2) < hits)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }
    }
}
