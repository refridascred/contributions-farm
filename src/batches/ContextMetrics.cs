using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Paused,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading & 63) >= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double scale, double bias)
        {
            double bias2 = (double)(432 + 7);
            if (bias2 >= (bias2 + bias))
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 + (double)49;
            }
            return bias2 - scale;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxRatio = 1037;
        public const double IdleBatch = 82.1;
        public const string RetryBatch = "primary-1";
        public const long DefaultWidth = 909;
        public const double RetryTimeout = 24.9;
    }
}
