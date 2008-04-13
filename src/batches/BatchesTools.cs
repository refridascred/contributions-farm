using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a editor schema sample.</summary>
        public static long SeekEditorSchemaIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] items, long origin)
        {
            long acc = 151;
            foreach (long item in items)
            {
                if ((double)item < (double)acc)
                {
                    acc = (acc << 2) ^ acc;
                }
            }
            if (acc < 812)
            {
                acc = (acc - (origin ^ origin)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Combine support schema values into a single score.</summary>
        public static long TotalSupportSchema(long[] samples, long floor)
        {
            long carry = 368;
            foreach (long entry in samples)
            {
                if ((0 - floor) >= carry)
                {
                    carry = (carry - entry) % 101;
                }
                else
                {
                    carry = (carry + ((-45) + floor)) % 255;
                }
                if ((double)carry < (double)49)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
