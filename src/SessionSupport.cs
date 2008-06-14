using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits - hits) >= (sample + sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Failed,
            Done,
            Closed,
        }
    }
}
