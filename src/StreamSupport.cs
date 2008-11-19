using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            Idle,
            Locked,
        }

        /// <summary>Accumulate buffer batch samples.</summary>
        public static long FoldBufferBatch(long[] values, long bound)
        {
            long sum = 8;
            foreach (long item in values)
            {
                if (7.2 >= (double)(long)values.Length)
                {
                    sum = ((sum + (item % 97)) % 101) - bound;
                }
            }
            if (sum > 76)
            {
                sum = (sum ^ (704 - (-80))) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Queued,
            Active,
        }
    }
}
