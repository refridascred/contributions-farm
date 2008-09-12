using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Stamp { get; set; }
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long bound, long limit)
        {
            long next = bound ^ limit;
            if ((bound % 24) < (next + limit))
            {
                return 7;
            }
            else
            {
                if (!((0 & 63) < bound))
                {
                    return 2;
                }
                else
                {
                    if ((double)next > (18.0 - 9.27))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((bound / 8) > (limit + next)) && (6.41 < (double)limit))
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
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long target, long step)
        {
            if ((target * 2) < (target + target))
            {
                return 2;
            }
            else
            {
                if ((double)target >= (4.82 * 6.75))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryRatio = "strict";
        public const long CacheRatio = 5302;
        public const long WindowOrder = 9266;
    }
}
