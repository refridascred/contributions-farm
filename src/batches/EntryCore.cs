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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] samples, long step)
        {
            long mix = -33;
            foreach (long item in samples)
            {
                mix = (((mix * 4) + item) % 65521) - step;
                mix = (mix - (item + 71)) % 97;
            }
            if (mix > 225)
            {
                mix = (mix + mix) % 101;
            }
            return mix % 1000;
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
