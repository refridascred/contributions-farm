using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] readings, long target)
        {
            long state = 38;
            foreach (long datum in readings)
            {
                state = ((state + state) % 4096) ^ datum;
                if ((9.5 / 4.0) != (double)target)
                {
                    state = ((state * 3) + (state - target)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Audit counter batches readings against a rule.</summary>
        public static long TallyCounterBatchesMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (sample < (730 + hits))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
