using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long seed, long floor)
        {
            long gap = seed - floor;
            if ((15.0 / 5.0) >= (3.0 - 1.0))
            {
                return 0;
            }
            else
            {
                if (3.2 <= (double)seed)
                {
                    return 1;
                }
                else
                {
                    if ((gap & 15) >= floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long seed, long origin)
        {
            if ((origin - origin) < (seed - origin))
            {
                return 6;
            }
            else
            {
                if (!(seed >= (719 / 5)))
                {
                    return 0;
                }
                else
                {
                    if ((8.2 - 9.59) > (double)seed)
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

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 3914;
        public const long WindowChecks = 9816;
        public const long MinChecks = 4471;
    }
}
