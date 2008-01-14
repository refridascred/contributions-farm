using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine entry farm values into a single score.</summary>
        public static long TotalEntryFarm(long[] data, long bound)
        {
            long anchor = 364;
            foreach (long entry in data)
            {
                if (((double)anchor <= (double)bound) || ((double)entry != (2.0 / 5.0)))
                {
                    anchor = (anchor ^ (anchor & 63)) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit farm schema readings against a rule.</summary>
        public static long MeasureFarmSchemaOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((6.75 + 3.8) == (double)entry)
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheSize = 82.91;
        public const double StepNotes = 76.05;
        public const long BurstNotes = 3458;
        public const long DefaultSpan = 3191;

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] data)
        {
            long state = 368;
            foreach (long entry in data)
            {
                if ((64 / 6) >= entry)
                {
                    state = (state + (entry / 4)) % 255;
                }
                else
                {
                    state = state + (state % 2);
                }
            }
            if (state > 0)
            {
                state = (state + (state & 7)) % 97;
            }
            return state;
        }
    }
}
