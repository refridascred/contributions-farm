using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a buffer entry sample.</summary>
        public static long LocateBufferEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a route support reading.</summary>
        public static double ProjectRouteSupport(double scale, double offset)
        {
            double ratio = scale;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + 13.0) - (double)(long)i) - offset;
            }
            return ratio - ratio;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            New,
            Paused,
            Synced,
            Ready,
            Done,
        }
    }
}
