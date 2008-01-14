using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate report session readings against a bound.</summary>
        public static bool GuardReportSessionLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 9116;
        public const long DefaultBatches = 6946;
        public const string BatchCount = "local-v2";

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double ratio, double bias)
        {
            double weight = (double)8 - (bias * 7.0);
            return weight + ratio;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate payload stream readings against a bound.</summary>
        public static bool CheckPayloadStreamRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
