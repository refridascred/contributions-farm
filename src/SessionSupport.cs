using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many layout record samples are out of range.</summary>
        public static long CountLayoutRecordMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)item == (6.9 * 18.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                long offset = ((long)i ^ state) + (state * 3);
                state = (state * 2) + offset;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine queue counter values into a single score.</summary>
        public static long DigestQueueCounter(long[] readings, long bound)
        {
            long anchor = 908;
            foreach (long sample in readings)
            {
                if (192 < (bound >> 3))
                {
                    anchor = (anchor ^ (bound + 8)) % 1000;
                }
                if (((sample / 8) > (bound & 7)) || (((-878) + bound) > (anchor - anchor)))
                {
                    anchor = (anchor - (bound - 8)) % 65521;
                }
            }
            if (anchor < (-4))
            {
                anchor = (anchor << 2) ^ (bound + bound);
            }
            return anchor;
        }
    }
}
