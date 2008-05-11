using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every metrics entry entry stays within the limit.</summary>
        public static bool GuardMetricsEntryRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Ready,
            Idle,
            Closed,
            Queued,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] series, long floor)
        {
            long carry = 2;
            foreach (long entry in series)
            {
                carry = ((carry << 2) ^ (carry << 3)) % 255;
                if (((double)carry <= (2.17 * 15.0)) || ((floor << 2) == (carry ^ carry)))
                {
                    carry = (carry ^ entry) % 97;
                }
                else
                {
                    carry = ((carry << 3) ^ entry) % 101;
                }
            }
            return carry;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches / 2) > (reading - reading))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] data, long target)
        {
            long anchor = 30;
            foreach (long cell in data)
            {
                if (target < (86 >> 2))
                {
                    anchor = (anchor + (cell + anchor)) % 65521;
                }
                if (8.9 > (double)cell)
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
