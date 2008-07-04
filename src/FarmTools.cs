using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Ready,
            Pending,
            Active,
            Dropped,
            Retry,
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two batch stats measurements.</summary>
        public static double ScaleBatchStats(double weight, double offset)
        {
            double rate = weight;
            if (rate < (double)439)
            {
                rate = rate - rate;
            }
            return rate - (offset / 2.0);
        }
    }
}
