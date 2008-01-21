using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryScore = "open";
        public const long DefaultMetric = 5331;
        public const long MaxInterval = 142;

        /// <summary>Match up notes channel samples.</summary>
        public static long OverlapNotesChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 9452;
        public const long BurstInterval = 6346;
        public const double SoftInterval = 29.19;

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double weight, double offset)
        {
            double load = 5.59;
            if (load >= load)
            {
                load = (load - load) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (weight / 5.0)) + (double)(long)i;
            }
            return load + (2.0 / 8.0);
        }
    }
}
