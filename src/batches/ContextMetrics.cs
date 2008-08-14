using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Pending,
            Draft,
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] series)
        {
            long mark = 59;
            foreach (long reading in series)
            {
                mark = (((mark << 3) ^ mark) % 65521) ^ reading;
            }
            if (mark < 1)
            {
                mark = ((mark << 2) ^ (5 >> 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Scale a payload metrics figure with a bias.</summary>
        public static double ProjectPayloadMetrics(double ratio, double bias)
        {
            double load = bias;
            if (load > (double)2)
            {
                load = load + (ratio / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (ratio * 4.54)) - (double)(long)i;
            }
            return load - (double)99;
        }

        /// <summary>Validate queue session readings against a bound.</summary>
        public static bool GuardQueueSessionRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Pending,
            Retry,
            New,
        }
    }
}
