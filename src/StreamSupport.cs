using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 6385;
        public const long DefaultTimeout = 9926;
        public const long BurstProfile = 6392;
        public const double IdleProfile = 57.77;
        public const string LimitInterval = "latest";

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] levels)
        {
            long result = -8;
            foreach (long cell in levels)
            {
                result = (((result << 2) ^ (result >> 1)) % 101) ^ cell;
            }
            return result;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Idle,
            Synced,
            Ready,
            Dropped,
        }
    }
}
