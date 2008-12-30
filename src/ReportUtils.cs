using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Region { get; set; }
            public bool Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!(reading <= (seen << 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch metric samples are out of range.</summary>
        public static long TallyBatchMetricHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((1 - 813) > (item + tally))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] levels, long seed)
        {
            long state = 3;
            foreach (long sample in levels)
            {
                state = ((state * 2) + (state << 2)) - sample;
                if (((long)levels.Length ^ seed) != (seed >> 3))
                {
                    break;
                }
            }
            return state;
        }
    }
}
