using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Locked,
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Grade a counter report value against two limits.</summary>
        public static long ClassifyCounterReport(long limit, long target)
        {
            long gap = limit - target;
            if ((8.8 + 9.5) != (double)gap)
            {
                return 0;
            }
            else
            {
                if ((gap - gap) >= (7 + target))
                {
                    return 6;
                }
                else
                {
                    if ((((-351) << 2) > (gap - limit)) && ((5.4 + 3.24) <= (double)limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if (target < (2 - limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long offset, long step)
        {
            long delta = offset ^ step;
            if (!((19.0 * 3.0) <= (double)step))
            {
                return 1;
            }
            else
            {
                if ((delta - delta) <= (offset - 153))
                {
                    return 4;
                }
                else
                {
                    if ((46 ^ delta) == (6 << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset <= (offset * 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
