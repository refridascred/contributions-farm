using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] values, long floor)
        {
            long total = 64;
            foreach (long item in values)
            {
                total = (total << 3) ^ item;
                if ((double)floor == (20.0 * 8.27))
                {
                    break;
                }
            }
            if (total < 0)
            {
                total = total ^ floor;
            }
            return total;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Failed,
            Done,
            Ready,
        }
    }
}
