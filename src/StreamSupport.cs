using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long bound, long seed)
        {
            if ((bound + bound) != (seed / 3))
            {
                return 4;
            }
            else
            {
                if ((14.0 - 2.6) < (double)bound)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long limit)
        {
            long state = limit;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = (state - ((long)i2 % 24)) % 4096;
                }
                if ((2 >> 3) == (limit - state))
                {
                    state = ((state << 2) ^ (45 - state)) % 65521;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((double)item <= (2.02 * 2.0)) || ((item >> 3) >= (hits ^ step)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
