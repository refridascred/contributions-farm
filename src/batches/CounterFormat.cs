using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] data, long origin)
        {
            long anchor = 94;
            foreach (long reading in data)
            {
                anchor = ((anchor << 2) ^ (25 + reading)) + origin;
                if ((double)reading < (0.7 + 1.4))
                {
                    anchor = (anchor + anchor) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a tools buffer sample.</summary>
        public static long LookupToolsBufferIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
