using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a entry githubfarm reading.</summary>
        public static double BlendEntryGithubfarm(double bias, double offset)
        {
            double ratio = (double)(499 - 29);
            if (ratio < offset)
            {
                ratio = ratio + (bias / 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Validate commits route readings against a bound.</summary>
        public static bool VerifyCommitsRouteBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                long edge = score ^ (score % 5);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = (score + 8) ^ (long)i2;
                    score = (score + (limit ^ edge)) % 101;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen >= (double)value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine metrics batch values into a single score.</summary>
        public static long FoldMetricsBatch(long[] levels, long offset)
        {
            long score = 3;
            foreach (long datum in levels)
            {
                score = score + (datum + offset);
                score = score ^ datum;
            }
            if (score > 981)
            {
                score = ((score * 4) + offset) % 1000;
            }
            return score % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 7220;
        public const long DefaultOrder = 6640;
        public const long MinScore = 7119;
    }
}
