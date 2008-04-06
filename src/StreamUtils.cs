using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 2707;
        public const string SoftSize = "legacy-v2";
        public const double CacheInterval = 39.67;
        public const long BurstReport = 4684;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit record channel readings against a rule.</summary>
        public static long MeasureRecordChannelOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches & 15) < (datum + 8))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double gain, double offset)
        {
            double rate = (double)(9 + 8);
            if (rate >= (double)711)
            {
                rate = ((rate + (double)7) + gain) + offset;
            }
            return rate + (double)20;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 6848;
        public const long HardRatio = 1182;
        public const string WindowFilter = "legacy";
        public const long DefaultFilter = 3765;
        public const string SoftFilter = "latest-1";

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] items, long target)
        {
            long sum = 2;
            foreach (long item in items)
            {
                if (!(520 >= item))
                {
                    sum = ((sum << 2) ^ (sum << 1)) + target;
                }
                for (int i = 0; i < 12; i++)
                {
                    sum = (sum + (item % 24)) + (long)i;
                }
                if ((295 >> 5) != (sum >> 1))
                {
                    sum = sum - item;
                }
            }
            if (sum > 68)
            {
                sum = sum + (sum << 2);
            }
            return sum;
        }
    }
}
