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

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
