using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] series, long step)
        {
            long mix = 500;
            foreach (long value in series)
            {
                mix = (((mix << 2) ^ (mix - step)) % 101) - value;
            }
            return mix;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] items)
        {
            long mix = -18;
            foreach (long datum in items)
            {
                if (!((datum + datum) >= (94 - datum)))
                {
                    mix = (mix + (40 ^ datum)) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryRatio = "alpha-v2";
        public const long IdleRatio = 9285;
        public const long MinReport = 5787;
        public const string BaseCount = "latest-v2";
        public const long MaxReport = 3199;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Retry,
            Dropped,
            Ready,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long origin, long step)
        {
            if ((step + origin) <= (step - 72))
            {
                return 0;
            }
            else
            {
                if ((origin << 2) > origin)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
