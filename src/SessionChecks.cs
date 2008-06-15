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

        /// <summary>Locate a filter tools reading by value.</summary>
        public static long FindFilterToolsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
