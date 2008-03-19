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

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                if ((step ^ step) >= ((long)i << 3))
                {
                    mix = (mix - (step & 63)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
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
