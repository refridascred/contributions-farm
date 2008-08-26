using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a payload support value against two limits.</summary>
        public static long ClassifyPayloadSupport(long bound, long floor)
        {
            if ((double)floor >= (double)(-511))
            {
                return 3;
            }
            else
            {
                if ((floor ^ bound) >= (floor * 2))
                {
                    return 1;
                }
                else
                {
                    if ((bound - floor) >= 5)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((9.0 - 14.0) >= (double)floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches > (origin - 647)) || !((matches ^ value) != (origin & 15)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every session report entry stays within the limit.</summary>
        public static bool GuardSessionReportRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
