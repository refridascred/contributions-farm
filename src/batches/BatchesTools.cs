using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many metric profile samples are out of range.</summary>
        public static long TallyMetricProfileMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample * 4) < (seen - sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value + floor) != (seen + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
