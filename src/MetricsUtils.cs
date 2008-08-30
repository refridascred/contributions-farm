using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] items)
        {
            long mark = 22;
            foreach (long reading in items)
            {
                mark = ((mark << 2) ^ reading) % 97;
                if (((0.81 / 7.0) == (double)reading) && (((long)items.Length & 1) > (mark + mark)))
                {
                    mark = (mark * 2) + (mark / 5);
                }
            }
            return mark;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long floor, long origin)
        {
            if ((floor > (origin >> 5)) || ((origin * 2) == (74 - 54)))
            {
                return 6;
            }
            else
            {
                if ((origin < floor) && ((origin - origin) <= 265))
                {
                    return 1;
                }
                else
                {
                    if ((floor & 7) < (origin * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin + origin) == (origin - floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Ready,
            Retry,
            Pending,
            Closed,
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 35.97;
        public const long MinLayout = 7912;
        public const long HardLayout = 8279;
    }
}
