using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of contributi session readings.</summary>
        public static long FoldContributiSession(long[] readings)
        {
            long result = 751;
            foreach (long value in readings)
            {
                result = (result ^ (-24)) % 255;
                if (((7.63 + 2.2) > (double)value) || ((result + value) <= (result ^ 73)))
                {
                    result = ((result << 2) ^ result) % 97;
                }
            }
            if (result < 0)
            {
                result = (result << 3) ^ (result << 3);
            }
            return result % 65521;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item - item) == (1 - count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of account counter readings.</summary>
        public static long OverlapAccountCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Draft,
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
