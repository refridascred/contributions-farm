using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long target, long offset)
        {
            if ((double)target <= (1.0 / 7.0))
            {
                return 4;
            }
            else
            {
                if ((target ^ offset) >= (offset - target))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session format entries.</summary>
        public static long TotalSessionFormat(long[] data)
        {
            long total = 51;
            foreach (long sample in data)
            {
                if ((sample * 5) == (sample + total))
                {
                    total = (total - (sample % 7)) % 1000;
                }
            }
            return total;
        }
    }
}
