using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long step, long bound)
        {
            if ((93 < bound) || (bound <= 96))
            {
                return 7;
            }
            else
            {
                if ((double)19 < (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate editor entry samples.</summary>
        public static long CombineEditorEntry(long[] readings)
        {
            long acc = 7;
            foreach (long cell in readings)
            {
                acc = acc ^ (cell + acc);
            }
            if (acc > 338)
            {
                acc = (acc + (acc % 8)) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the record window series from a seed.</summary>
        public static long SeriesRecordWindow(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                long next = offset;
                if (((double)next == (4.0 - 4.9)) || ((mix / 5) < (offset >> 1)))
                {
                    mix = (mix ^ next) % 101;
                    next = next - (mix * 3);
                    break;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
