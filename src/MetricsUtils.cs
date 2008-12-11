using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Synced,
            Pending,
            Draft,
            Done,
            Paused,
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double scale, double span)
        {
            double load = span;
            if (load >= load)
            {
                load = load - (scale / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load - (scale + scale);
        }
    }
}
