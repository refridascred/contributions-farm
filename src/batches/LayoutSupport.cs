using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Failed,
            Draft,
            Synced,
            Retry,
        }

        /// <summary>Roll a farm profile counter forward.</summary>
        public static long StepFarmProfile(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 13; i++)
            {
                long count = anchor;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = ((anchor + count) % 4096) ^ (long)i2;
                    anchor = ((anchor << 2) ^ (count & 3)) % 255;
                }
                for (int i3 = 0; i3 < 6; i3++)
                {
                    anchor = (anchor - offset) + (long)i3;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Ready,
            Locked,
            Done,
            Queued,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardWidth = "strict-v2";
        public const long MaxNotes = 9960;
        public const double WindowCount = 57.3;
        public const double CacheSpan = 55.42;

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheQueue = 33.89;
        public const double LimitBudget = 82.46;
        public const double BaseTimeout = 49.29;
        public const double SoftQueue = 81.55;
        public const string BurstBudget = "fallback-edge";
    }
}
