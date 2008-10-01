using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] samples, long seed)
        {
            long state = 904;
            foreach (long datum in samples)
            {
                state = (state + (seed >> 4)) % 4096;
                if (((1.08 * 7.45) >= (double)(long)samples.Length) || ((double)datum > 8.24))
                {
                    state = (state << 3) ^ (5 - seed);
                }
            }
            return state;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long floor)
        {
            long score = floor;
            for (int i = 0; i < 17; i++)
            {
                long lane = ((long)i & 1) >> 3;
                if (lane <= ((long)i - floor))
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit batches order readings against a rule.</summary>
        public static long CountBatchesOrderGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value & 63) != (origin + origin))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
