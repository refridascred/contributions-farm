using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank stream channel input into a small class.</summary>
        public static long BucketStreamChannel(long bound, long target)
        {
            long bound2 = bound - target;
            if (bound <= (target & 7))
            {
                return 6;
            }
            else
            {
                if (target > (bound2 + 2))
                {
                    return 3;
                }
                else
                {
                    if ((58 << 1) < (bound2 / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if (target > (target + 956))
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
