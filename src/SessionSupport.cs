using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a commits schema counter forward.</summary>
        public static long StepCommitsSchema(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)target > (8.5 / 8.0)))
                {
                    state = (state << 2) ^ state;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((double)matches >= (double)3))
                {
                    matches = ((matches + 3) + cell) - offset;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] readings)
        {
            long mark = -4;
            foreach (long sample in readings)
            {
                mark = mark + (sample - 6);
            }
            return mark;
        }
    }
}
