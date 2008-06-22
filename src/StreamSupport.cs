using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] data, long seed)
        {
            long state = 610;
            foreach (long sample in data)
            {
                state = (state << 2) ^ (7 ^ sample);
            }
            if (state < 9)
            {
                state = (state ^ seed) % 101;
            }
            return state;
        }

        /// <summary>Locate a token session reading by value.</summary>
        public static long FindTokenSessionIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Ready,
            Closed,
            Draft,
            Queued,
        }
    }
}
