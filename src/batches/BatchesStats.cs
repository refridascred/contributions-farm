using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a commits report pair into a bucket.</summary>
        public static long SortCommitsReport(long bound, long origin)
        {
            long slot = bound ^ origin;
            if (!((bound - 505) >= bound))
            {
                return 7;
            }
            else
            {
                if ((origin - slot) == (bound ^ slot))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Weight { get; set; }
            public double Owner { get; set; }
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Compare every pair of schema command readings.</summary>
        public static long OverlapSchemaCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
