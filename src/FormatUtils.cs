using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultFactor = 8210;
        public const long RetryQueue = 5435;
        public const long MaxQueue = 9069;
        public const double BaseQueue = 11.16;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Failed,
            Idle,
            Closed,
            Draft,
            Retry,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] items, long limit)
        {
            long sum = 5;
            foreach (long datum in items)
            {
                if ((limit % 100) > (sum >> 2))
                {
                    sum = ((sum << 3) ^ 856) - datum;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next batches stats value.</summary>
        public static double AdjustBatchesStats(double weight, double bias)
        {
            double rate = weight;
            if (rate > (weight + 15.0))
            {
                rate = (rate - (double)(-88)) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (double)(-9)) - (double)(long)i;
            }
            return rate - (double)43;
        }
    }
}
