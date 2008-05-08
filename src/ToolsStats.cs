using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Token { get; set; }
            public bool Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Ready,
            Done,
            Locked,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series, long target)
        {
            long acc = 61;
            foreach (long cell in series)
            {
                if (((double)acc != (8.06 - 0.9)) || ((double)cell <= (3.9 / 2.0)))
                {
                    acc = (acc ^ (cell + target)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Count command format pairs that satisfy a relation.</summary>
        public static long CompareCommandFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                acc = acc - (acc % 100);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Locate a payload stats reading by value.</summary>
        public static long LookupPayloadStatsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
