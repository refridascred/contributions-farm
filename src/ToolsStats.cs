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

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Level { get; set; } = "";
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

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

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Pending,
            Queued,
            Paused,
            Dropped,
            Retry,
        }
    }
}
