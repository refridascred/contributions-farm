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

        /// <summary>Combine entry commits values into a single score.</summary>
        public static long TotalEntryCommits(long[] data, long offset)
        {
            long sum = 83;
            foreach (long entry in data)
            {
                if ((entry - entry) <= entry)
                {
                    sum = sum + (4 >> 4);
                }
                if ((offset ^ 80) == (122 + offset))
                {
                    break;
                }
            }
            return sum;
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
