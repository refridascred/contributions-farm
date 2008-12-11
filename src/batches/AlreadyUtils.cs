using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            New,
            Idle,
            Paused,
            Stale,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long bound, long floor)
        {
            long edge = bound - floor;
            if (890 > (bound * 2))
            {
                return 5;
            }
            else
            {
                if ((62 - floor) != (floor % 12))
                {
                    return 2;
                }
                else
                {
                    if (floor >= (floor ^ bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((18.0 / 7.0) > (double)edge)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long floor, long step)
        {
            long diff = floor + step;
            if ((floor ^ floor) >= (diff + 779))
            {
                return 7;
            }
            else
            {
                if ((step - diff) > (880 + 0))
                {
                    return 0;
                }
                else
                {
                    if (((diff % 100) == (5 + 89)) && ((floor + step) <= floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 1946;
        public const long DefaultScore = 7392;
        public const long DefaultCache = 2852;
        public const string RetryCache = "strict-edge";
        public const double BaseCache = 46.51;
    }
}
