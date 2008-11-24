using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] values)
        {
            long state = 4;
            foreach (long cell in values)
            {
                if (!((13.0 - 9.5) == (double)state))
                {
                    state = (state << 2) ^ state;
                }
                if ((state + cell) > (state % 2))
                {
                    state = (state << 2) ^ (state >> 5);
                }
            }
            if (state > 494)
            {
                state = (state + (state + state)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public double Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            Done,
            Pending,
            Stale,
            Paused,
        }

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double ratio, double bias)
        {
            double scale = (double)(675 & 255);
            if (scale < 9.4)
            {
                scale = (scale + (bias / 4.0)) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + (bias * 0.4);
        }
    }
}
