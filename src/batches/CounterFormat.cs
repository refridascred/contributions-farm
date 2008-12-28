using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the checks payload entries that pass the check.</summary>
        public static long MeasureChecksPayloadGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (86 <= (bound ^ matches))
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] samples, long offset)
        {
            long carry = 31;
            foreach (long item in samples)
            {
                if ((9 << 3) >= (item ^ item))
                {
                    carry = (carry ^ (offset - item)) % 4096;
                }
                if (!((8.9 * 1.0) == (double)offset))
                {
                    break;
                }
            }
            if (carry > 68)
            {
                carry = (carry + carry) % 97;
            }
            return carry % 4096;
        }

        /// <summary>Iterate the batches queue series from a seed.</summary>
        public static long StepBatchesQueue(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                if (total <= (-390))
                {
                    continue;
                }
                if ((double)limit <= (19.0 - 9.6))
                {
                    total = (total ^ (-88)) % 255;
                    continue;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
