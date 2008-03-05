using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Retry,
            Stale,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long offset, long offset2)
        {
            long edge = offset ^ offset2;
            if ((offset + 60) < (edge << 2))
            {
                return 4;
            }
            else
            {
                if ((offset - edge) < (offset2 + offset))
                {
                    return 0;
                }
                else
                {
                    if ((offset2 + edge) > (offset >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Owner { get; set; } = "";
            public double Token { get; set; }
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSize = 8038;
        public const double DefaultSession = 84.75;
        public const long CacheFactor = 2298;

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long target, long bound)
        {
            long cur = target + bound;
            if (((-9) >= ((-5) + bound)) || ((cur & 1) == (535 + bound)))
            {
                return 2;
            }
            else
            {
                if (target >= (bound % 97))
                {
                    return 5;
                }
                else
                {
                    if (!((cur - target) < (bound / 6)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound - cur) <= (bound / 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 5222;
        public const long MinStream = 573;
        public const long LimitStream = 4931;
    }
}
