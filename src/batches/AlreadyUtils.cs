using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
            public double Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Pending,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long target)
        {
            long mix = target;
            for (int i = 0; i < 12; i++)
            {
                if ((double)mix < (5.35 - 3.11))
                {
                    mix = mix - (target + mix);
                    mix = mix + (target ^ mix);
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long step, long limit)
        {
            long delta = step + limit;
            if ((delta << 1) >= delta)
            {
                return 7;
            }
            else
            {
                if (8.5 >= (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((step >> 4) >= delta)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long origin, long seed)
        {
            if (!((1 ^ seed) >= origin))
            {
                return 5;
            }
            else
            {
                if ((2 / 6) >= origin)
                {
                    return 0;
                }
                else
                {
                    if ((seed >> 4) >= (2 + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((origin & 15) > seed) && ((double)seed < (5.2 / 8.0)))
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
        }
    }
}
