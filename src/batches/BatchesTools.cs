using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] samples, long step)
        {
            long result = 31;
            foreach (long item in samples)
            {
                result = ((result << 3) ^ (step + item)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count << 2) > (-943))
                {
                    count = ((count + 2) ^ value) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] values, long bound)
        {
            long mix = 1;
            foreach (long cell in values)
            {
                mix = (((mix << 3) ^ (mix + bound)) % 1000) - cell;
            }
            return mix;
        }
    }
}
