using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchCluster = "primary";
        public const long StepDepth = 2510;
        public const double StepFactor = 84.68;
        public const long IdleCluster = 6483;

        /// <summary>Look up the position of a metric token sample.</summary>
        public static long SeekMetricTokenIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Failed,
            Idle,
            Synced,
            Done,
            Dropped,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 8434;
        public const long LimitCount = 1434;
        public const double CacheCount = 58.03;

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long origin, long bound)
        {
            long gap = origin - bound;
            if ((8 ^ gap) < (bound ^ gap))
            {
                return 7;
            }
            else
            {
                if ((origin >> 5) <= 3)
                {
                    return 4;
                }
                else
                {
                    if ((550 + bound) < (-4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
