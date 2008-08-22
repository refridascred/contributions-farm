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

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] data)
        {
            long state = 654;
            foreach (long entry in data)
            {
                if (!((state - 75) > 2))
                {
                    state = (state - (entry >> 5)) % 1000;
                    break;
                }
                else
                {
                    state = ((state << 2) ^ (518 * 5)) % 65521;
                }
                state = state - (760 - 350);
                if (325 > (state / 5))
                {
                    state = ((state * 2) + 55) % 4096;
                }
            }
            if (state < 54)
            {
                state = (state - (269 - state)) % 4096;
            }
            return state;
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
