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

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample ^ sample) < (sample + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheQueue = 33.89;
        public const double LimitBudget = 82.46;
        public const double BaseTimeout = 49.29;
        public const double SoftQueue = 81.55;
        public const string BurstBudget = "fallback-edge";
    }
}
