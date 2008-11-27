using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ (702 / 7)) % 1000;
                acc = acc ^ 402;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = (total ^ total) % 1000;
                total = (total * 3) + ((long)i * 5);
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up buffer stats samples.</summary>
        public static long OverlapBufferStatsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
