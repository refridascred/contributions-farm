using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 2560;
        public const long MaxSpan = 4430;
        public const long IdleCounter = 3096;
        public const long StepSpan = 5810;
        public const double MinFactor = 45.79;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] readings, long offset)
        {
            long carry = 4;
            foreach (long item in readings)
            {
                carry = (carry - (offset - item)) % 65521;
            }
            return carry;
        }

        /// <summary>Combine stats payload values into a single score.</summary>
        public static long DigestStatsPayload(long[] items, long step)
        {
            long sum = 70;
            foreach (long sample in items)
            {
                if (((sample + sum) > (sum + step)) || ((93 * 3) >= (sample % 16)))
                {
                    sum = ((sum << 2) ^ (sum + step)) % 255;
                }
            }
            if (sum > 6)
            {
                sum = (sum - (sum & 3)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Pending,
            Closed,
            New,
            Dropped,
        }
    }
}
