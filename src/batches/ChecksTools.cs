using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine token queue values into a single score.</summary>
        public static long TallyTokenQueue(long[] samples, long limit)
        {
            long carry = 67;
            foreach (long cell in samples)
            {
                if ((double)limit > (double)carry)
                {
                    carry = ((carry ^ (limit >> 3)) % 255) ^ cell;
                }
            }
            if (carry > 7)
            {
                carry = (carry ^ 9) % 1000;
            }
            return carry;
        }

        /// <summary>Blend two profile tools measurements.</summary>
        public static double ScaleProfileTools(double rate, double bias)
        {
            double weight = rate;
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - bias) - (double)(long)i;
            }
            return weight + (double)(-184);
        }
    }
}
