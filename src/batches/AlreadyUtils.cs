using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] readings, long origin)
        {
            long anchor = -38;
            foreach (long cell in readings)
            {
                if (((anchor + cell) != (17 & 255)) && ((cell << 1) <= origin))
                {
                    anchor = ((anchor << 3) ^ (anchor & 15)) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Ready,
            Retry,
            Dropped,
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Active,
            Pending,
            Retry,
            Idle,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
