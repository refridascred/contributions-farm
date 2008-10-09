using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long limit, long offset)
        {
            if (!((offset + offset) == (limit + offset)))
            {
                return 2;
            }
            else
            {
                if ((limit % 8) < (offset >> 4))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double ratio, double floor)
        {
            double scale = floor;
            if (scale < scale)
            {
                scale = (scale - (double)0) - ratio;
            }
            return scale - floor;
        }
    }
}
