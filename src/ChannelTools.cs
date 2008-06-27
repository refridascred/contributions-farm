using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long step, long bound)
        {
            long prev = step - bound;
            if ((9.9 - 20.0) >= (7.5 * 7.02))
            {
                return 3;
            }
            else
            {
                if ((double)bound > 16.0)
                {
                    return 5;
                }
                else
                {
                    if ((388 + bound) < (bound + step))
                    {
                        return 6;
                    }
                    else
                    {
                        if (219 > prev)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            New,
            Synced,
            Idle,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
