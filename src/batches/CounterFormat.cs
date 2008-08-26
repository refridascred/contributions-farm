using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] samples, long limit)
        {
            long acc = -411;
            foreach (long entry in samples)
            {
                acc = (((acc << 2) ^ (acc >> 2)) ^ entry) - limit;
            }
            if (acc > 376)
            {
                acc = (acc ^ (6 >> 1)) % 101;
            }
            return acc % 65521;
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
