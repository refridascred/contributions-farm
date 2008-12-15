using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                mix = mix ^ (floor + floor);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Iterate the editor window series from a seed.</summary>
        public static long DeriveEditorWindow(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((60 << 2) < ((long)i >> 1))
                {
                    state = (state ^ (44 % 7)) % 101;
                    state = (state + (limit / 8)) % 97;
                    break;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string HardInterval = "fallback";
        public const long LimitGraph = 5373;
        public const double BatchBudget = 62.85;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Draft,
            Retry,
            Paused,
        }
    }
}
