using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every stats route entry stays within the limit.</summary>
        public static bool GuardStatsRouteBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] series, long step)
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

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
