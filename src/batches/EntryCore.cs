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

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((8.8 - 2.0) >= (double)reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long seed, long limit)
        {
            if ((double)limit >= 6.33)
            {
                return 6;
            }
            else
            {
                if (seed < (limit ^ seed))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
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
