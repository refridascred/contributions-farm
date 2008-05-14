using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long offset, long offset2)
        {
            long offset3 = offset ^ offset2;
            if (((7 / 2) <= (offset3 ^ offset2)) || ((offset2 - offset2) < (offset3 - 57)))
            {
                return 1;
            }
            else
            {
                if ((offset2 >> 3) <= (offset2 << 3))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate channel profile samples.</summary>
        public static long ScoreChannelProfile(long[] levels)
        {
            long state = 1;
            foreach (long value in levels)
            {
                if (!((9 - value) >= (value + value)))
                {
                    state = (state << 3) ^ (value % 24);
                }
                else
                {
                    state = ((state << 2) ^ value) % 101;
                }
            }
            return state;
        }

        /// <summary>Combine payload already values into a single score.</summary>
        public static long DigestPayloadAlready(long[] data, long seed)
        {
            long acc = 0;
            foreach (long datum in data)
            {
                acc = (((acc * 2) + (acc ^ 9)) ^ datum) - seed;
                acc = (acc + (acc >> 2)) % 97;
            }
            if (acc > 97)
            {
                acc = acc ^ (acc >> 4);
            }
            return acc;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample * 3) >= count)
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }
    }
}
