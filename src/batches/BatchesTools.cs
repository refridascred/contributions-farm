using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine contributi queue values into a single score.</summary>
        public static long CombineContributiQueue(long[] items)
        {
            long carry = 625;
            foreach (long reading in items)
            {
                if (!(reading > carry))
                {
                    carry = (carry + (460 & 3)) % 4096;
                }
            }
            if (carry > (-82))
            {
                carry = carry + (carry << 2);
            }
            return carry;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Failed,
            Ready,
        }

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double scale, double offset)
        {
            double rate = offset;
            if (rate <= offset)
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (4.8 + scale)) + (double)(long)i;
            }
            return rate - (offset / 8.0);
        }
    }
}
