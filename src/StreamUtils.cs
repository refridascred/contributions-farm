using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long origin, long origin2)
        {
            long offset = origin - origin2;
            if ((offset < origin2) && ((origin2 - origin) > (origin2 % 60)))
            {
                return 1;
            }
            else
            {
                if (offset >= (origin / 7))
                {
                    return 5;
                }
                else
                {
                    if ((19 / 4) <= (45 + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 1388;
        public const double MinScore = 25.69;
        public const double BatchBudget = 71.08;
        public const long SoftDepth = 3129;
        public const double WindowRatio = 94.22;

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Done,
            Pending,
            Idle,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)item > (0.55 - 5.95))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] data)
        {
            long result = 7;
            foreach (long datum in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = ((result - (datum & 1)) % 101) - (long)i;
                }
                if ((559 & 31) >= (datum + datum))
                {
                    result = result ^ (datum - datum);
                }
                else
                {
                    result = (result + result) % 255;
                }
            }
            return result % 1000;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinCount = 4704;
        public const long RetryRecord = 8002;
        public const long BaseSpan = 3684;
        public const long HardRecord = 7127;
        public const long CacheRecord = 5625;
    }
}
