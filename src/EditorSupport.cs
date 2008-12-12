using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitSize = 1627;
        public const string BurstLevel = "staging";
        public const double MinDepth = 63.75;
        public const long BaseStream = 5728;

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long seed, long step)
        {
            if (((seed - step) < 941) || (seed <= (547 - 912)))
            {
                return 6;
            }
            else
            {
                if ((5.45 / 2.0) <= (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((seed / 4) > (81 + step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((1.9 / 6.0) > (double)seed) && ((seed - step) < (step * 5)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long step, long limit)
        {
            long next = step ^ limit;
            if ((8.9 - 6.4) >= (double)step)
            {
                return 4;
            }
            else
            {
                if (((step ^ next) >= (limit % 100)) || ((6 + limit) > limit))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
