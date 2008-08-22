using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long origin, long target)
        {
            long slot = origin ^ target;
            if (slot <= (target + origin))
            {
                return 8;
            }
            else
            {
                if ((slot + 674) <= (origin - 860))
                {
                    return 4;
                }
                else
                {
                    if (((origin ^ 675) != (origin * 3)) && ((double)origin == (17.0 + 17.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((origin + slot) <= (slot * 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long origin, long limit)
        {
            if (((origin >> 4) > limit) && ((394 + limit) > origin))
            {
                return 7;
            }
            else
            {
                if ((limit * 2) > origin)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "strict-edge";
        public const long HardMetric = 8143;
        public const long MinSize = 2641;
        public const long BatchMetric = 9302;
        public const string StepRatio = "latest-v2";

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Queued,
            Locked,
            Paused,
            Stale,
            Dropped,
        }
    }
}
