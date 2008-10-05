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

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
