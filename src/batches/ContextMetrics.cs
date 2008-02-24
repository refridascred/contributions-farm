using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double rate, double span)
        {
            double mean = (double)2;
            if (mean > rate)
            {
                mean = mean + span;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (5.0 + span)) - (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Done,
            Failed,
            Closed,
            Pending,
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
