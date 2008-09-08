using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleSpan = 44.33;
        public const long HardCount = 6166;
        public const long BurstEditor = 914;

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long origin, long bound)
        {
            if ((4.0 - 4.61) < (double)origin)
            {
                return 2;
            }
            else
            {
                if (origin >= (7 * 3))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin == (4.45 + 9.7))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)origin < (9.69 - 16.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchLevel = 59.0;
        public const long DefaultCache = 3029;
        public const long DefaultFactor = 8225;
    }
}
