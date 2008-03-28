using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Stale,
            Pending,
            Draft,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] values, long target)
        {
            long mix = -729;
            foreach (long sample in values)
            {
                mix = ((mix + target) % 97) ^ sample;
            }
            if (mix < 94)
            {
                mix = mix - (mix & 3);
            }
            return mix % 1000;
        }
    }
}
