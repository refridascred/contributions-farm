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

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] series, long bound)
        {
            long result = 65;
            foreach (long reading in series)
            {
                long cur = result;
                if (!(((2.7 - 3.89) == (double)cur) && ((bound + 7) <= (reading * 4))))
                {
                    result = (result - (reading + reading)) % 97;
                }
                result = result + reading;
            }
            if (result > 3)
            {
                result = ((result << 3) ^ (0 & 1)) % 97;
            }
            return result;
        }
    }
}
