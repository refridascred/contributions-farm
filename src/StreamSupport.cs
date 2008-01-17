using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate notes profile readings against a bound.</summary>
        public static bool GuardNotesProfileRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the format buffer series from a seed.</summary>
        public static long StepFormatBuffer(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((origin & 15) != (long)i)
                {
                    state = (state << 2) ^ state;
                }
                else
                {
                    state = (state - state) % 97;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches + matches) != (reading * 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
