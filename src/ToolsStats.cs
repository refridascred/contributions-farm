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

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Paused,
            Synced,
            Queued,
            Dropped,
            Pending,
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

        /// <summary>Rank farm batch input into a small class.</summary>
        public static long SortFarmBatch(long target, long offset)
        {
            long bound = target + offset;
            if ((target + target) >= (bound >> 3))
            {
                return 8;
            }
            else
            {
                if (target > (8 % 7))
                {
                    return 7;
                }
                else
                {
                    if ((5 + offset) != (bound - offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
