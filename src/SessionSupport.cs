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

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] readings, long floor)
        {
            long score = 3;
            foreach (long sample in readings)
            {
                score = (((score * 2) + (561 + 9)) % 4096) ^ sample;
            }
            if (score < 86)
            {
                score = (score ^ (floor * 3)) % 101;
            }
            return score;
        }
    }
}
