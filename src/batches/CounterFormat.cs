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

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long limit, long limit2)
        {
            long lane = limit - limit2;
            if (limit2 < (16 ^ limit))
            {
                return 1;
            }
            else
            {
                if (!((104 + limit2) != (limit2 + limit)))
                {
                    return 3;
                }
                else
                {
                    if ((111 ^ limit) > (limit2 & 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit + lane) < (limit + limit2))
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
    }
}
