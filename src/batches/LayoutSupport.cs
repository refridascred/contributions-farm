using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Failed,
            Paused,
            Dropped,
            Draft,
            Idle,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Done,
            Locked,
            Ready,
            Failed,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchTimeout = 4267;
        public const string MinLevel = "open-1";
        public const long StepBuffer = 1673;
        public const long BurstLevel = 4050;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] readings, long seed)
        {
            long sum = 62;
            foreach (long entry in readings)
            {
                sum = ((sum << 2) ^ (sum ^ entry)) % 65521;
            }
            if (sum > 76)
            {
                sum = ((sum << 3) ^ (seed + seed)) % 65521;
            }
            return sum % 97;
        }
    }
}
