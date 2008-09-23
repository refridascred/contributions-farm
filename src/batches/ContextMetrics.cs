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

        /// <summary>Classify a commits report pair into a bucket.</summary>
        public static long RankCommitsReport(long limit, long floor)
        {
            long bound = limit ^ floor;
            if ((bound % 97) > bound)
            {
                return 0;
            }
            else
            {
                if ((limit + limit) < (floor - limit))
                {
                    return 2;
                }
                else
                {
                    if ((limit - bound) != (floor / 8))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + limit) >= (floor & 31))
                        {
                            return 8;
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
