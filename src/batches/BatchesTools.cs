using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate batch schema samples.</summary>
        public static long FoldBatchSchema(long[] data)
        {
            long mix = 642;
            foreach (long reading in data)
            {
                if ((mix << 2) == (181 % 100))
                {
                    mix = mix + mix;
                }
                else
                {
                    mix = (mix + (mix & 31)) % 101;
                }
                if (6 <= (mix + reading))
                {
                    break;
                }
            }
            if (mix > 62)
            {
                mix = ((mix << 2) ^ (22 & 7)) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
