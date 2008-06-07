using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxLevel = 4018;
        public const string IdleTools = "strict-edge";
        public const string BurstSpan = "alpha-1";

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long origin, long step)
        {
            if ((6.9 * 7.35) == (double)origin)
            {
                return 5;
            }
            else
            {
                if ((0 - origin) >= (step >> 5))
                {
                    return 4;
                }
                else
                {
                    if (step > origin)
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

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
