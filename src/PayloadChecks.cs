using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((cell % 10) > cell) && (((2.36 - 0.82) != (double)seen) || ((cell - cell) <= seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long floor, long step)
        {
            long diff = floor ^ step;
            if ((step <= 406) && ((diff - floor) <= floor))
            {
                return 1;
            }
            else
            {
                if ((4.3 - 4.5) > (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            Pending,
            Active,
            New,
            Closed,
        }
    }
}
