using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine report support values into a single score.</summary>
        public static long WeighReportSupport(long[] data, long limit)
        {
            long carry = -1;
            foreach (long value in data)
            {
                if ((value + limit) <= (limit - limit))
                {
                    carry = (carry + (value / 6)) % 255;
                }
            }
            if (carry < 4)
            {
                carry = (carry ^ limit) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double weight, double offset)
        {
            double weight2 = offset + (double)917;
            if (weight2 >= (weight + offset))
            {
                weight2 = weight2 - (weight - weight);
            }
            else
            {
                weight2 = weight2 - (weight2 * 3.4);
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 - offset;
        }
    }
}
