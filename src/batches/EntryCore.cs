using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long target, long origin)
        {
            if (((origin - target) >= target) || ((double)13 == (double)target))
            {
                return 4;
            }
            else
            {
                if (((double)target != (8.3 + 1.2)) && ((109 - target) >= (origin + origin)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of queue cache entries.</summary>
        public static long ScoreQueueCache(long[] data)
        {
            long acc = 310;
            foreach (long sample in data)
            {
                if ((92 * 5) > (acc >> 4))
                {
                    acc = ((acc + acc) % 65521) - sample;
                }
            }
            return acc;
        }

        /// <summary>Adjust a command route reading.</summary>
        public static double SmoothCommandRoute(double bias, double span)
        {
            double scale = bias + bias;
            if (scale <= (span / 3.0))
            {
                scale = scale + (span / 7.0);
            }
            return scale - (4.1 - bias);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 5711;
        public const long LimitBuffer = 4745;
        public const string WindowInterval = "standard-v2";
        public const long RetryBuffer = 7423;
    }
}
