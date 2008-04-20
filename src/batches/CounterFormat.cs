using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading >> 2) != (6 % 64))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Active,
            Stale,
            Idle,
            Draft,
            Ready,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
