using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate stats graph readings against a bound.</summary>
        public static bool GuardStatsGraphBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every context counter entry stays within the limit.</summary>
        public static bool GuardContextCounterBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
