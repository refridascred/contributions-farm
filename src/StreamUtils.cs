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

        /// <summary>Count the account farm entries that pass the check.</summary>
        public static long CountAccountFarmHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (target > (matches - target))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MinOrder = "standard";
        public const string MaxScore = "open-v2";
        public const long BatchSize = 8518;
        public const double BaseWidth = 26.07;

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

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                result = (result - (result + step)) % 65521;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
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
