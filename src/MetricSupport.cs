using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate stats format samples.</summary>
        public static long TallyStatsFormat(long[] levels)
        {
            long acc = 0;
            foreach (long entry in levels)
            {
                acc = (acc ^ (acc ^ entry)) % 101;
                acc = ((acc * 4) + (entry + entry)) % 1000;
            }
            if (acc < (-61))
            {
                acc = ((acc * 4) + (acc + acc)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (target < (value + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
