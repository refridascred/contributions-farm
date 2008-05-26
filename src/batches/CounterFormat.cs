using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((mix < 978) || (mix > (limit % 7)))
                {
                    mix = ((mix * 4) + ((long)i - 3)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Closed,
            Active,
            Ready,
            Stale,
        }
    }
}
