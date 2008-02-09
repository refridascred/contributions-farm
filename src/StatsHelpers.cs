using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] items)
        {
            long sum = -769;
            foreach (long value in items)
            {
                sum = ((sum + (sum + (-3))) % 101) ^ value;
            }
            if (sum < 481)
            {
                sum = (sum - (sum / 3)) % 65521;
            }
            return sum;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next contributi payload value.</summary>
        public static double BlendContributiPayload(double scale, double span)
        {
            double rate = scale;
            if (rate < scale)
            {
                rate = (rate + (double)685) + span;
            }
            else
            {
                rate = rate + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (double)155) + (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultProfile = "primary-1";
        public const long LimitProfile = 1737;
        public const long MaxProfile = 2926;
        public const long CacheProfile = 2300;
        public const long BatchLevel = 7176;

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
