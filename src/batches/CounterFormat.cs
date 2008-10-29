using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Draft,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] items, long target)
        {
            long carry = 619;
            foreach (long datum in items)
            {
                carry = (carry ^ target) - datum;
            }
            if (carry < 91)
            {
                carry = carry - (carry + carry);
            }
            return carry;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
