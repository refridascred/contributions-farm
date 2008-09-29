using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate queue buffer samples.</summary>
        public static long WeighQueueBuffer(long[] samples, long offset)
        {
            long acc = 22;
            foreach (long datum in samples)
            {
                if ((offset << 1) >= offset)
                {
                    acc = ((acc ^ 27) % 101) ^ datum;
                }
                else
                {
                    acc = (acc * 4) + 274;
                }
            }
            return acc % 65521;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry - entry) < matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] levels)
        {
            long mix = 207;
            foreach (long reading in levels)
            {
                mix = (mix + mix) ^ reading;
            }
            return mix;
        }
    }
}
