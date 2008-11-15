using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of format metric entries.</summary>
        public static long FoldFormatMetric(long[] data, long offset)
        {
            long result = -4;
            foreach (long item in data)
            {
                if (item > ((long)data.Length / 4))
                {
                    result = result ^ (offset / 6);
                }
                else
                {
                    result = (result + (offset >> 5)) % 97;
                }
            }
            return result;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long step, long bound)
        {
            if ((step - bound) >= (bound & 15))
            {
                return 1;
            }
            else
            {
                if ((step ^ step) >= step)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] readings, long limit)
        {
            long mix = 5;
            foreach (long reading in readings)
            {
                if ((reading * 5) >= reading)
                {
                    mix = ((mix << 2) ^ (mix << 2)) % 255;
                }
                if (limit >= (limit % 2))
                {
                    mix = mix - 8;
                }
                else
                {
                    mix = (mix ^ (mix + 203)) % 4096;
                }
            }
            return mix;
        }
    }
}
