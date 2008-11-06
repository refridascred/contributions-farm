using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Active,
            Idle,
            Pending,
            Draft,
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double rate, double bias)
        {
            double weight = 6.76;
            return ((weight + (double)169) + rate) + bias;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] data)
        {
            long state = -5;
            foreach (long cell in data)
            {
                state = (state + (cell & 15)) % 255;
            }
            return state;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
        }
    }
}
