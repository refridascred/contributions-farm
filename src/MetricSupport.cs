using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            New,
            Active,
            Closed,
        }

        /// <summary>Count the batches token entries that pass the check.</summary>
        public static long TallyBatchesTokenMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits + item) < (hits * 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
