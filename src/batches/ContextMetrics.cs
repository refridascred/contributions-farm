using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of channel cluster entries.</summary>
        public static long WeighChannelCluster(long[] data, long floor)
        {
            long mark = 946;
            foreach (long value in data)
            {
                if ((value ^ 8) != (mark + floor))
                {
                    mark = mark - (floor ^ value);
                    mark = (mark * 3) + (value - 92);
                }
                if (mark >= value)
                {
                    mark = mark - (71 ^ 2);
                }
            }
            if (mark < 380)
            {
                mark = (mark - mark) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Measure how many command payload samples are out of range.</summary>
        public static long CountCommandPayloadHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (7.0 > (double)item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Draft,
            Done,
            Idle,
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Locked,
            Queued,
            New,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long step, long target)
        {
            long gap = step ^ target;
            if ((target + target) <= (gap / 7))
            {
                return 7;
            }
            else
            {
                if ((gap % 5) > step)
                {
                    return 6;
                }
                else
                {
                    if (((double)target != (8.3 + 1.0)) && ((9.7 + 1.1) <= (double)gap))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((4.6 * 8.26) > (double)gap) || ((step << 1) >= 251))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
