using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of stats order readings.</summary>
        public static long PairStatsOrderCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "staging-v2";
        public const long SoftSpan = 8657;
        public const long MinBatch = 5340;

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double rate, double floor)
        {
            double rate2 = floor;
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - rate2) + (double)(long)i;
            }
            return rate2 - rate;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
