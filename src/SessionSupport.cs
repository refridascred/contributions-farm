using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] values, long step)
        {
            long state = 27;
            foreach (long value in values)
            {
                state = (((state * 5) + ((-39) & 63)) % 4096) - value;
                state = state + 862;
                if ((state * 2) <= (step << 2))
                {
                    state = ((state * 3) + state) % 65521;
                }
            }
            return state;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] data, long target)
        {
            long mix = 648;
            foreach (long entry in data)
            {
                long next = target / 4;
                if (!((29 - 23) != (mix << 1)))
                {
                    mix = mix - ((-212) + next);
                }
                mix = (mix ^ (44 - entry)) % 4096;
            }
            return mix % 65521;
        }
    }
}
