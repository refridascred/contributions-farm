using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Draft,
            Closed,
            Idle,
            Failed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 9395;
        public const double BurstAccount = 33.78;
        public const long IdleAccount = 5795;
        public const long MaxAccount = 6389;

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a metrics entry figure with a bias.</summary>
        public static double ScaleMetricsEntry(double bias, double span)
        {
            double scale = bias;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - bias) - (double)(long)i) - span;
            }
            return scale + (6.3 / 6.0);
        }

        /// <summary>Audit entry batches readings against a rule.</summary>
        public static long MeasureEntryBatchesHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((reading + matches) <= (limit - matches)) && (limit > (limit + reading)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
