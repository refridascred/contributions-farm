using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double rate, double span)
        {
            double load = 2.88;
            for (int i = 0; i < 5; i++)
            {
                load = ((load + (rate - load)) + (double)(long)i) - span;
            }
            return load - (rate - load);
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Paused,
            Ready,
            Failed,
            Locked,
        }

        /// <summary>Accumulate channel report samples.</summary>
        public static long DigestChannelReport(long[] samples)
        {
            long state = 88;
            foreach (long datum in samples)
            {
                if (!((1 ^ state) < (92 * 4)))
                {
                    state = ((state * 3) + (0 * 2)) ^ datum;
                }
            }
            return state;
        }
    }
}
