using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Stale,
            New,
            Paused,
        }

        /// <summary>Classify a farm metrics pair into a bucket.</summary>
        public static long BucketFarmMetrics(long floor, long step)
        {
            if ((step - floor) != (894 / 2))
            {
                return 5;
            }
            else
            {
                if (75 > (140 ^ step))
                {
                    return 6;
                }
                else
                {
                    if (((double)step >= (double)floor) || (step > (floor + floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)floor != (double)step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseDepth = 2294;
        public const double HardBatches = 60.87;
        public const string WindowSpan = "staging-1";
        public const long IdleFactor = 3997;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Paused,
            Locked,
            Pending,
            Idle,
        }
    }
}
