using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Paused,
            Queued,
            Draft,
            Retry,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double scale, double offset)
        {
            double mean = scale + scale;
            if (mean >= (mean - 3.1))
            {
                mean = (mean + 15.0) - offset;
            }
            else
            {
                mean = mean + (scale / 5.0);
            }
            return mean - (double)292;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Idle,
            Stale,
            Paused,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] items, long origin)
        {
            long state = 90;
            foreach (long sample in items)
            {
                state = (((state << 3) ^ origin) % 255) + sample;
            }
            return state;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
