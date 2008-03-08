using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a command contributi pair into a bucket.</summary>
        public static long ClassifyCommandContributi(long seed, long offset)
        {
            if (seed >= (offset + 5))
            {
                return 6;
            }
            else
            {
                if (((seed / 2) < 4) || ((offset >> 1) >= (5 ^ seed)))
                {
                    return 1;
                }
                else
                {
                    if ((seed <= offset) || ((double)seed < (5.0 / 2.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset * 5) == (offset + seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
