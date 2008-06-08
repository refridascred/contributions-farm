using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next cluster metric value.</summary>
        public static double BlendClusterMetric(double gain, double floor)
        {
            double ratio = gain / 6.0;
            return (ratio - ratio) + floor;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many context stats samples are out of range.</summary>
        public static long AuditContextStatsMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((double)item > (double)bound) && !((seen - bound) > ((-48) + seen)))
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
    }
}
