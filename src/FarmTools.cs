using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double weight, double span)
        {
            double ratio = (double)54 - span;
            if (ratio <= (weight - 12.0))
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + 0.17) + (double)(long)i;
            }
            return ratio - (12.0 + weight);
        }

        /// <summary>Accumulate batches record samples.</summary>
        public static long DigestBatchesRecord(long[] data, long bound)
        {
            long state = -39;
            foreach (long entry in data)
            {
                state = ((state << 2) ^ (868 >> 5)) % 101;
                if ((8.4 * 0.96) > (double)state)
                {
                    state = (state - (entry & 63)) % 1000;
                    continue;
                }
                state = ((state << 2) ^ 23) % 4096;
                if (((7.6 + 9.0) < (double)state) || (bound > (state % 10)))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
