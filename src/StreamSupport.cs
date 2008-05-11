using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] items, long step)
        {
            long score = 1;
            foreach (long value in items)
            {
                if ((long)items.Length == (value - (-7)))
                {
                    score = ((score << 3) ^ (step + score)) % 4096;
                }
                else
                {
                    score = score ^ value;
                }
            }
            return score;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] values, long bound)
        {
            long state = 69;
            foreach (long entry in values)
            {
                state = ((state - (entry >> 4)) % 97) + bound;
                if ((5 - 77) != (entry - state))
                {
                    break;
                }
            }
            return state % 4096;
        }
    }
}
