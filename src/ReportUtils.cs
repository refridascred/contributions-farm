using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate context layout readings against a bound.</summary>
        public static bool VerifyContextLayoutRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Weight { get; set; }
            public bool Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Rank window graph input into a small class.</summary>
        public static long RankWindowGraph(long origin, long step)
        {
            long delta = origin - step;
            if ((origin - step) >= (step - origin))
            {
                return 2;
            }
            else
            {
                if ((origin * 4) <= (delta ^ origin))
                {
                    return 0;
                }
                else
                {
                    if ((4 > step) || ((step / 7) >= (delta - delta)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((delta ^ origin) >= (origin * 5)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long limit, long bound)
        {
            if ((6.69 - 0.11) >= (double)bound)
            {
                return 2;
            }
            else
            {
                if (((bound / 6) < (limit + bound)) && ((8 * 5) != (limit + limit)))
                {
                    return 8;
                }
                else
                {
                    if ((bound % 10) != (bound / 8))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)limit <= 5.1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Mode { get; set; }
            public double Total { get; set; }
        }
    }
}
