using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 1830;
        public const long IdleSpan = 442;
        public const long MinNotes = 171;
        public const long HardDepth = 2463;
    }
}
