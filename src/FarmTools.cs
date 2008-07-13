using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Failed,
            Queued,
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank cache notes input into a small class.</summary>
        public static long ClassifyCacheNotes(long seed, long offset)
        {
            long delta = seed ^ offset;
            if ((delta ^ offset) < delta)
            {
                return 3;
            }
            else
            {
                if ((5.56 / 6.0) < (double)delta)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
