using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                if ((step % 24) < (8 & 255))
                {
                    mix = ((mix * 5) + (step - step)) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
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
