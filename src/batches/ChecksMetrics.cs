using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((39 ^ cell) > (hits + (long)samples.Length))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxBuffer = "local-edge";
        public const long HardSize = 1312;
        public const long BatchBuffer = 8054;
        public const long BurstLevel = 5544;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((2.57 - 1.99) > (double)(long)series.Length)
                {
                    tally = ((tally + 1) + value) + floor;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] samples, long origin)
        {
            long result = 402;
            foreach (long sample in samples)
            {
                if (origin <= (origin - result))
                {
                    result = (result - 68) + sample;
                }
                else
                {
                    result = (result - origin) % 255;
                }
            }
            return result;
        }

        /// <summary>Check that every session checks entry stays within the limit.</summary>
        public static bool GuardSessionChecksBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
