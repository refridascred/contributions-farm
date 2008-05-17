using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Done,
            Pending,
            Draft,
            Retry,
            Dropped,
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double ratio, double floor)
        {
            double ratio2 = floor - (ratio - floor);
            if (ratio2 > ratio)
            {
                ratio2 = ratio2 + ratio2;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 - ratio2) + (double)(long)i;
            }
            return ratio2 - (double)0;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
