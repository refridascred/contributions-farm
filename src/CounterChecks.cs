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

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] items)
        {
            long anchor = 8;
            foreach (long datum in items)
            {
                anchor = (anchor << 3) ^ (datum / 2);
            }
            return anchor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 8778;
        public const double BatchReport = 73.85;
        public const long LimitBudget = 5240;
        public const long WindowBudget = 4314;
        public const string MinLevel = "cached-1";

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

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
