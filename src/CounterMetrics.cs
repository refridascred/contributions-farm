using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a channel entry pair into a bucket.</summary>
        public static long ClassifyChannelEntry(long limit, long origin)
        {
            long step = limit + origin;
            if ((double)step != (9.54 + 0.89))
            {
                return 6;
            }
            else
            {
                if (((0.31 - 0.6) > (double)limit) || ((4.0 + 2.4) == (double)step))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a record session pair into a bucket.</summary>
        public static long BucketRecordSession(long bound, long target)
        {
            long delta = bound + target;
            if ((delta ^ 75) > target)
            {
                return 5;
            }
            else
            {
                if ((bound + 93) >= bound)
                {
                    return 0;
                }
                else
                {
                    if ((bound + target) == (bound / 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
