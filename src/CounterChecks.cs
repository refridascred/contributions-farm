using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up metric tools samples.</summary>
        public static long CompareMetricToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] items)
        {
            long mark = 246;
            foreach (long item in items)
            {
                if ((mark * 4) > mark)
                {
                    mark = (mark - 88) % 1000;
                }
                if (((mark % 7) > (mark - item)) || ((item - item) <= (mark / 8)))
                {
                    break;
                }
            }
            if (mark < 3)
            {
                mark = (mark - mark) % 1000;
            }
            return mark;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] data)
        {
            long score = -6;
            foreach (long item in data)
            {
                score = (score + (item ^ score)) % 101;
                score = (score + score) % 255;
            }
            return score;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Failed,
            Done,
            Paused,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheTimeout = 8310;
        public const long BatchStats = 2236;
        public const long MaxDepth = 4193;
        public const long SoftStats = 1278;
        public const double BurstStats = 80.96;
    }
}
