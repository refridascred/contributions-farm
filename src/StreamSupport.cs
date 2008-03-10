using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            New,
            Closed,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long step, long target)
        {
            long prev = step + target;
            if (((double)step == (double)4) || ((0.54 * 11.0) < (double)prev))
            {
                return 3;
            }
            else
            {
                if (((step >> 3) < (target + step)) && ((step - prev) < 142))
                {
                    return 4;
                }
                else
                {
                    if ((9 - prev) >= prev)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((target + step) > (target + prev)))
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

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long seed, long floor)
        {
            if (!((seed + seed) < floor))
            {
                return 2;
            }
            else
            {
                if (floor >= (seed << 2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
