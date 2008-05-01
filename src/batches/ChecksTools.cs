using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long bound, long seed)
        {
            long diff = bound + seed;
            if ((diff ^ 46) < 889)
            {
                return 0;
            }
            else
            {
                if ((bound + bound) <= (seed / 7))
                {
                    return 1;
                }
                else
                {
                    if ((bound ^ diff) != (bound / 6))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed - 365) < (diff << 3))
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

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Closed,
            Pending,
            Idle,
            Locked,
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseGraph = "legacy-v2";
        public const string BaseTimeout = "alpha-edge";
        public const long LimitRatio = 7219;
    }
}
