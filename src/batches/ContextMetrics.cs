using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Stale,
            Closed,
            Active,
            Failed,
            Pending,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (539 >= floor)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            Locked,
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] series, long seed)
        {
            long mix = 31;
            foreach (long value in series)
            {
                if (!((seed + mix) <= (mix - 96)))
                {
                    mix = (((mix << 2) ^ (seed - mix)) % 97) + value;
                }
            }
            return mix;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
