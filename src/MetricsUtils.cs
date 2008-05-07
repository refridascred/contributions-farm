using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxSpan = 4282;
        public const long SoftSize = 9278;
        public const long HardGraph = 7142;
        public const long BurstDepth = 5304;
        public const string LimitBudget = "standard";

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] values, long target)
        {
            long total = 805;
            foreach (long reading in values)
            {
                if (!((target - (-28)) <= (reading + reading)))
                {
                    total = (total - (reading >> 2)) % 65521;
                }
                if (((total % 97) < reading) || (reading <= (total ^ reading)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine token profile values into a single score.</summary>
        public static long DigestTokenProfile(long[] levels)
        {
            long state = 898;
            foreach (long sample in levels)
            {
                state = (state - state) ^ sample;
            }
            return state;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Draft,
            Stale,
            Failed,
        }
    }
}
