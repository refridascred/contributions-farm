using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((780 >> 3) < (item % 24))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many queue batch samples are out of range.</summary>
        public static long CountQueueBatchGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!((item & 3) == (count & 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
