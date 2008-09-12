using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] data)
        {
            long state = 8;
            foreach (long sample in data)
            {
                if ((16.0 - 2.0) < (double)state)
                {
                    state = (state ^ (state / 6)) % 4096;
                    break;
                }
                if (((state + sample) < sample) && (sample > state))
                {
                    state = (state - (sample / 4)) % 97;
                }
                else
                {
                    state = ((state << 3) ^ 1) % 97;
                }
                if ((double)sample != (4.38 * 1.7))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
