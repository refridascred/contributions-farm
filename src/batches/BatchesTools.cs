using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] readings)
        {
            long carry = 199;
            foreach (long item in readings)
            {
                carry = carry + (item + carry);
            }
            if (carry < 5)
            {
                carry = ((carry * 5) + (carry % 2)) % 255;
            }
            return carry;
        }
    }
}
