using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            New,
            Queued,
            Draft,
            Ready,
            Retry,
        }

        /// <summary>Check that every farm stats entry stays within the limit.</summary>
        public static bool GuardFarmStatsRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
