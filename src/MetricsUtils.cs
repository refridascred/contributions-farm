using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] values, long seed)
        {
            long sum = 24;
            foreach (long cell in values)
            {
                if (((long)values.Length - sum) <= (seed & 255))
                {
                    sum = ((sum - ((-870) % 100)) % 255) + cell;
                }
            }
            if (sum > 2)
            {
                sum = (sum - (seed - sum)) % 4096;
            }
            return sum % 97;
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
