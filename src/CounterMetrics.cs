using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Queued,
            Pending,
            Ready,
            Locked,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((count - 6) < (origin - count)))
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Stale,
            Failed,
            Idle,
        }

        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double ratio, double offset)
        {
            double scale = offset - ratio;
            if (scale <= ratio)
            {
                scale = scale - 9.0;
            }
            return scale + (scale - offset);
        }
    }
}
