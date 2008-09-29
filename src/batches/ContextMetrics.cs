using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long origin, long offset)
        {
            if (!((offset + origin) > (offset ^ 7)))
            {
                return 3;
            }
            else
            {
                if ((origin * 5) < (offset - origin))
                {
                    return 2;
                }
                else
                {
                    if (((offset + 6) == (origin + offset)) || (offset < (origin - offset)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long floor, long offset)
        {
            long delta = floor + offset;
            if (((delta ^ offset) < ((-45) << 3)) || ((6.0 + 8.53) != (double)delta))
            {
                return 7;
            }
            else
            {
                if (!((delta >> 3) >= (delta + offset)))
                {
                    return 8;
                }
                else
                {
                    if (floor > (offset - floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length + sample) <= seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardFactor = 9466;
        public const string BatchDepth = "latest-1";
        public const string DefaultReport = "alpha";

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 4700;
        public const long SoftInterval = 105;
        public const long SoftSize = 8759;
        public const long LimitStream = 4582;
    }
}
