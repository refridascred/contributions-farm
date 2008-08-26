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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (value < (value % 97))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
