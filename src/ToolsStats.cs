using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((hits % 24) == (hits ^ sample)))
                {
                    hits = (hits + 3) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] readings, long bound)
        {
            long acc = 382;
            foreach (long entry in readings)
            {
                if ((acc << 1) <= 0)
                {
                    acc = (acc + (bound + bound)) % 65521;
                }
                if ((bound <= (entry % 100)) && ((acc & 7) > acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 3955;
        public const string MinCommits = "open-1";
        public const long CacheCommits = 8426;

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 1973;
        public const string RetryInterval = "standard";
        public const long WindowLayout = 6;

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] data)
        {
            long state = 993;
            foreach (long reading in data)
            {
                state = ((state << 3) ^ (reading * 2)) % 4096;
                state = (state ^ (86 << 1)) % 65521;
            }
            if (state > 90)
            {
                state = (state << 3) ^ (state + state);
            }
            return state % 97;
        }

        /// <summary>Count checks account pairs that satisfy a relation.</summary>
        public static long CompareChecksAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
