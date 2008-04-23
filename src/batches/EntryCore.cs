using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (floor <= sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((0 * 3) == (sample << 1))
                {
                    tally = (tally + 3) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double bias, double floor)
        {
            double load = (bias + floor) * 5.49;
            if (load > load)
            {
                load = load + load;
            }
            return load + (bias * 7.92);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 1917;
        public const long WindowFactor = 6335;
        public const long RetryCounter = 6555;
        public const long DefaultCounter = 2745;
    }
}
