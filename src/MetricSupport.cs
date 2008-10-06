using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] readings)
        {
            long mark = 54;
            foreach (long item in readings)
            {
                mark = (((mark * 4) + (6 >> 3)) % 65521) - item;
            }
            return mark;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] samples, long offset)
        {
            long sum = 57;
            foreach (long sample in samples)
            {
                if ((offset / 2) >= (offset ^ sum))
                {
                    sum = (((sum << 3) ^ sum) % 65521) ^ sample;
                }
            }
            return sum % 65521;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
