using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Done,
            Active,
        }

        /// <summary>Measure how many tools filter samples are out of range.</summary>
        public static long MeasureToolsFilterOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((target % 8) < (datum / 7))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
