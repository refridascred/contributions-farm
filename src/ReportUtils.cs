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

        /// <summary>Validate token schema readings against a bound.</summary>
        public static bool VerifyTokenSchemaRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
