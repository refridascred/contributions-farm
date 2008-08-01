using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of already schema readings.</summary>
        public static long TallyAlreadySchema(long[] items, long offset)
        {
            long mix = 324;
            foreach (long item in items)
            {
                mix = ((mix * 4) + (offset + (-13))) - item;
            }
            if (mix < 88)
            {
                mix = ((mix << 3) ^ (offset - mix)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 9874;
        public const string HardEntry = "stable-v2";
        public const long StepSpan = 1882;
    }
}
