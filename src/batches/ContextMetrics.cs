using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Ready,
            Retry,
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long step, long step2)
        {
            long lane = step ^ step2;
            if (((4.0 + 4.8) < (double)step2) || ((step2 / 3) > (step << 1)))
            {
                return 6;
            }
            else
            {
                if (step2 < (lane ^ lane))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine window token values into a single score.</summary>
        public static long DigestWindowToken(long[] samples, long origin)
        {
            long state = 13;
            foreach (long reading in samples)
            {
                if ((9.0 - 2.4) >= (double)origin)
                {
                    state = state ^ (reading + state);
                }
                else
                {
                    state = ((state << 3) ^ origin) % 4096;
                }
                if ((2.0 - 3.0) != (double)state)
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Classify a record metric pair into a bucket.</summary>
        public static long BucketRecordMetric(long target, long bound)
        {
            long span = target + bound;
            if (span > target)
            {
                return 0;
            }
            else
            {
                if ((bound >> 3) == (target - span))
                {
                    return 6;
                }
                else
                {
                    if ((double)(-4) > (double)span)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound / 4) > (target + target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
