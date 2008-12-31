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

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftTimeout = 4611;
        public const long BurstRatio = 9011;
        public const string BurstTimeout = "primary-v2";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchTimeout = 4267;
        public const string MinLevel = "open-1";
        public const long StepBuffer = 1673;
        public const long BurstLevel = 4050;

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] data)
        {
            long state = 553;
            foreach (long sample in data)
            {
                state = (state ^ (sample & 63)) % 4096;
            }
            return state;
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
