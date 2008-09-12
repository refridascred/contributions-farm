using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count filter metric pairs that satisfy a relation.</summary>
        public static long MatchFilterMetricCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((limit + limit) == (limit >> 4))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowBudget = 5684;
        public const long CacheSize = 6496;
        public const double CacheCommits = 16.46;
        public const string BaseCommits = "strict-edge";
        public const long SoftCommits = 5259;

        /// <summary>Match up commits profile samples.</summary>
        public static long PairCommitsProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
