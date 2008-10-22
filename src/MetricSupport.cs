using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a token notes value against two limits.</summary>
        public static long ClassifyTokenNotes(long origin, long target)
        {
            if ((target > (69 + target)) && ((double)target < (double)origin))
            {
                return 2;
            }
            else
            {
                if ((origin > (target << 3)) && ((target >> 4) <= (target % 16)))
                {
                    return 5;
                }
                else
                {
                    if (!((origin % 24) >= (origin + target)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target - origin) >= (8 >> 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 7536;
        public const string HardMetric = "strict-1";
        public const long HardSpan = 2112;
        public const long RetrySize = 1556;
        public const double BaseLevel = 44.57;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 3) + (243 + (long)i)) % 255;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
