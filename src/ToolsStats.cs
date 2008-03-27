using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Stale,
            Done,
            Dropped,
            New,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long target, long origin)
        {
            long next = target + origin;
            if (!((13 % 24) != (target >> 1)))
            {
                return 0;
            }
            else
            {
                if ((target <= (target + target)) && ((0 - next) >= (238 << 3)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next schema support value.</summary>
        public static double ProjectSchemaSupport(double gain, double span)
        {
            double mean = gain;
            if (mean <= (double)(-7))
            {
                mean = (mean + gain) + span;
            }
            else
            {
                mean = mean - (gain - mean);
            }
            return mean + (double)746;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Queued,
            Pending,
            Paused,
        }
    }
}
