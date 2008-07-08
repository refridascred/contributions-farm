using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value >= (value % 100)) && ((value >> 4) < (8 ^ 970)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseBatch = "strict-edge";
        public const long BaseInterval = 9125;
        public const long HardBatch = 7324;

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of githubfarm entry entries.</summary>
        public static long TallyGithubfarmEntry(long[] values, long seed)
        {
            long score = 7;
            foreach (long item in values)
            {
                score = (score ^ score) + seed;
                if (((638 + item) < (item % 8)) || ((score >> 5) < (item - 910)))
                {
                    score = (score - (score % 2)) % 1000;
                }
                else
                {
                    score = (score - (score << 3)) % 4096;
                }
            }
            return score % 65521;
        }
    }
}
