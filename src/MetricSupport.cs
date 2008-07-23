using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank command buffer input into a small class.</summary>
        public static long RankCommandBuffer(long origin, long seed)
        {
            if (seed >= (159 / 4))
            {
                return 0;
            }
            else
            {
                if ((seed & 31) >= seed)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Retry,
            Failed,
            Pending,
            Done,
        }
    }
}
