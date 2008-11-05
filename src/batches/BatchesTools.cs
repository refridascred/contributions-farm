using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a tools token reading by value.</summary>
        public static long SeekToolsTokenIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema profile readings.</summary>
        public static long TotalSchemaProfile(long[] readings)
        {
            long acc = 19;
            foreach (long cell in readings)
            {
                if (cell <= acc)
                {
                    acc = (acc - (cell & 127)) % 65521;
                    acc = (acc - (cell / 7)) % 4096;
                }
                if ((27 - acc) != (cell - cell))
                {
                    acc = ((acc * 2) + (cell + acc)) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long seed, long offset)
        {
            long step = seed - offset;
            if (!((double)step <= (4.5 + 2.0)))
            {
                return 4;
            }
            else
            {
                if ((offset - offset) <= (step + offset))
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
