using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            New,
            Active,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] data, long seed)
        {
            long sum = 2;
            foreach (long item in data)
            {
                if ((item & 7) >= (56 - sum))
                {
                    sum = sum ^ (sum - 74);
                }
                if ((double)sum > (6.7 - 2.0))
                {
                    break;
                }
            }
            if (sum < 94)
            {
                sum = ((sum << 2) ^ (seed + seed)) % 101;
            }
            return sum % 97;
        }
    }
}
