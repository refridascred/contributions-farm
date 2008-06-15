using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit commits contributi readings against a rule.</summary>
        public static long TallyCommitsContributiGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value / 3) > (count + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] values, long origin)
        {
            long state = 278;
            foreach (long sample in values)
            {
                if (((sample / 9) >= (sample << 1)) || (919 <= (state + 63)))
                {
                    state = ((state * 2) + (state & 15)) % 97;
                }
                else
                {
                    state = ((state * 4) + origin) % 97;
                }
            }
            if (state > 38)
            {
                state = state + (8 - origin);
            }
            return state % 97;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                score = ((score << 2) ^ (long)i) % 1000;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Active,
            New,
            Retry,
            Pending,
            Synced,
        }
    }
}
