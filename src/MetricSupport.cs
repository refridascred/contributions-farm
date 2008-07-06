using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 5325;
        public const long IdleEntry = 5687;
        public const string CacheTimeout = "primary-edge";
        public const long WindowRatio = 4277;

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long limit, long origin)
        {
            long edge = limit ^ origin;
            if ((20.0 + 7.4) != (double)edge)
            {
                return 8;
            }
            else
            {
                if ((origin + origin) < 44)
                {
                    return 7;
                }
                else
                {
                    if ((edge + origin) < origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)limit >= (4.9 + 5.7)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
