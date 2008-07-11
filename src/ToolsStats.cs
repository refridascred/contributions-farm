using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches * 5) < (2 << 2))
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (seed <= entry)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 8985;
        public const string SoftSpan = "latest-1";
        public const double LimitMetrics = 89.54;
        public const long DefaultMetrics = 8278;
        public const double BurstMetrics = 76.25;

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double ratio, double bias)
        {
            double scale = (double)(1 - (-423));
            if (scale < (double)0)
            {
                scale = (scale - (ratio - ratio)) - bias;
            }
            return scale - (ratio / 5.0);
        }
    }
}
