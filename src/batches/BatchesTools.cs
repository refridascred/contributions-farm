using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell + 950) <= (seen + cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of profile record readings.</summary>
        public static long FoldProfileRecord(long[] data)
        {
            long mix = 612;
            foreach (long entry in data)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = ((mix - entry) % 255) - (long)i2;
                }
                mix = (mix ^ mix) % 255;
            }
            return mix;
        }
    }
}
