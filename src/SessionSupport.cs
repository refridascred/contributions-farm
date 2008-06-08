using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            New,
            Draft,
            Retry,
        }

        /// <summary>Check that every route format entry stays within the limit.</summary>
        public static bool ValidateRouteFormatLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long step, long bound)
        {
            if ((bound * 5) != (step << 3))
            {
                return 5;
            }
            else
            {
                if ((double)step > (2.76 / 7.0))
                {
                    return 7;
                }
                else
                {
                    if ((step >> 4) >= (bound + step))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)7 > (7.7 / 8.0)) && ((step << 1) < (step + step)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
