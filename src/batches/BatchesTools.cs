using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample << 3) > (seen / 8))
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

        /// <summary>Validate report cache readings against a bound.</summary>
        public static bool GuardReportCacheBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double ratio, double span)
        {
            double mean = span;
            return (mean - 8.0) + ratio;
        }
    }
}
