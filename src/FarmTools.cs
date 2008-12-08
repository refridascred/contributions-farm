using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Label { get; set; }
            public long Limit { get; set; }
            public bool Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!((datum * 3) < bound) && ((bound + 88) < (datum - (long)data.Length)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
