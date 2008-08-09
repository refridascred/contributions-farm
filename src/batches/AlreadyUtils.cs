using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                sum = sum - ((long)i + offset);
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] readings, long origin)
        {
            long mark = 5;
            foreach (long cell in readings)
            {
                if ((double)origin < (1.93 * 0.5))
                {
                    mark = (((mark << 2) ^ (mark + origin)) % 4096) + cell;
                }
            }
            if (mark < 415)
            {
                mark = (mark * 2) + (mark - mark);
            }
            return mark;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 8499;
        public const long HardGithubfarm = 8610;
        public const long MinFactor = 4182;
        public const double LimitLevel = 83.18;

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] readings)
        {
            long anchor = 248;
            foreach (long sample in readings)
            {
                if ((double)anchor < (1.7 - 0.01))
                {
                    anchor = ((anchor * 3) + (303 % 16)) - sample;
                }
            }
            return anchor;
        }
    }
}
