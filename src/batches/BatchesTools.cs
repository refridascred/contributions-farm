using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate queue layout samples.</summary>
        public static long DigestQueueLayout(long[] series)
        {
            long acc = 4;
            foreach (long cell in series)
            {
                if (((cell >> 4) > cell) && ((cell >> 5) > cell))
                {
                    acc = acc ^ (cell + cell);
                }
            }
            return acc;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long offset, long origin)
        {
            if ((origin & 63) > origin)
            {
                return 2;
            }
            else
            {
                if (offset < (origin ^ 177))
                {
                    return 0;
                }
                else
                {
                    if (!((offset + 3) <= (offset % 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 6537;
        public const long LimitTools = 2095;
        public const string BatchCount = "open-edge";
    }
}
