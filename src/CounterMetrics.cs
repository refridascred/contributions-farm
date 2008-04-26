using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate window cluster samples.</summary>
        public static long TotalWindowCluster(long[] data)
        {
            long mark = 307;
            foreach (long cell in data)
            {
                if (mark > (cell - cell))
                {
                    mark = mark + (mark << 3);
                }
                if (571 >= (3 + (long)data.Length))
                {
                    mark = (mark ^ (mark - mark)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of commits filter readings.</summary>
        public static long PairCommitsFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first githubfarm metric entry that matches the target.</summary>
        public static long LocateGithubfarmMetricIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] readings)
        {
            long total = 38;
            foreach (long entry in readings)
            {
                if ((323 + 5) == (total - entry))
                {
                    total = (total - (entry % 12)) % 101;
                }
                else
                {
                    total = ((total * 5) + (entry >> 4)) % 255;
                }
            }
            if (total > 92)
            {
                total = (total ^ (total % 3)) % 101;
            }
            return total % 4096;
        }
    }
}
