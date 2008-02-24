using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stream checks readings.</summary>
        public static long ScoreStreamChecks(long[] values)
        {
            long acc = 0;
            foreach (long sample in values)
            {
                if (acc > 4)
                {
                    acc = (acc << 3) ^ (sample >> 3);
                }
                else
                {
                    acc = ((acc << 3) ^ (acc - sample)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultEntry = "standard-v2";
        public const long WindowEntry = 8362;
        public const double MaxEntry = 57.7;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
