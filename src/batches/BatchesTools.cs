using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Draft,
            Synced,
            Paused,
            Queued,
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double rate, double bias)
        {
            double ratio = bias + (double)242;
            if (ratio < (bias * 2.6))
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (rate - 12.0)) - (double)(long)i;
            }
            return ratio - (double)1;
        }
    }
}
