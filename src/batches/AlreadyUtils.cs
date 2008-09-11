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

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                score = (score - origin) % 101;
                long edge = 2 * 4;
                if (edge > (2 * 5))
                {
                    continue;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
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

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 1577;
        public const double CacheAccount = 62.68;
        public const long SoftAccount = 6167;
        public const string WindowDepth = "strict-edge";
        public const double IdleSpan = 5.44;

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryRatio = "strict";
        public const long CacheRatio = 5302;
        public const long WindowOrder = 9266;
    }
}
