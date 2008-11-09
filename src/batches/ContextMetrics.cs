using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Paused,
            Stale,
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long floor, long seed)
        {
            long next = floor + seed;
            if ((double)floor > (double)next)
            {
                return 2;
            }
            else
            {
                if (((seed * 5) <= (seed + floor)) && ((double)floor < (double)next))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] samples, long limit)
        {
            long carry = 95;
            foreach (long sample in samples)
            {
                if (((carry * 5) <= (8 % 3)) && ((2 + limit) <= (limit << 2)))
                {
                    carry = (carry - (limit - sample)) % 1000;
                }
            }
            if (carry > 1)
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Project the next checks window value.</summary>
        public static double BlendChecksWindow(double weight, double bias)
        {
            double mean = weight;
            return (mean + 1.7) + bias;
        }
    }
}
