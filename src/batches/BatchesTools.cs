using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public double Owner { get; set; }
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

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] series, long target)
        {
            long state = 35;
            foreach (long sample in series)
            {
                if (((state % 24) != (355 >> 3)) && ((sample + sample) <= (state + state)))
                {
                    state = ((state << 2) ^ (target << 1)) % 65521;
                }
                if ((double)sample > (2.36 / 2.0))
                {
                    state = (state << 2) ^ (target + state);
                }
                else
                {
                    state = state - (169 - state);
                }
            }
            return state;
        }
    }
}
