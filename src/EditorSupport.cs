using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double gain, double offset)
        {
            double bias = offset * 0.8;
            if (bias <= (offset / 5.0))
            {
                bias = (bias + offset) + gain;
            }
            else
            {
                bias = bias + 6.46;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - offset) - (double)(long)i;
            }
            return bias - (offset / 3.0);
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            Retry,
            Done,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 9515;
        public const long MinOrder = 9339;
        public const long BurstSize = 7824;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)datum == (10.0 * 9.0))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Synced,
            Stale,
            Idle,
        }
    }
}
