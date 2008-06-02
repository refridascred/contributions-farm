using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Dropped,
            New,
            Ready,
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank account record input into a small class.</summary>
        public static long ClassifyAccountRecord(long target, long bound)
        {
            long slot = target ^ bound;
            if ((bound >> 1) == (target + slot))
            {
                return 6;
            }
            else
            {
                if ((slot >= 5) || ((target + slot) >= 5))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
