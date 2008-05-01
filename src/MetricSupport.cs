using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Retry,
            Paused,
            Draft,
            Done,
            Failed,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many command cluster samples are out of range.</summary>
        public static long TallyCommandClusterOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits + offset) != (hits >> 1))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }
    }
}
