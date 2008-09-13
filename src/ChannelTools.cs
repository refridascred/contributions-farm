using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Ready,
            Dropped,
            Closed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleBudget = 84.66;
        public const long IdleWindow = 4777;
        public const long BaseTimeout = 1130;
        public const string HardWindow = "primary-1";
        public const long RetryWindow = 2113;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long step, long bound)
        {
            long lane = step + bound;
            if ((bound << 2) >= (bound & 3))
            {
                return 0;
            }
            else
            {
                if ((step / 9) < bound)
                {
                    return 3;
                }
                else
                {
                    if (!((bound << 1) == (lane % 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (lane <= 995)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
