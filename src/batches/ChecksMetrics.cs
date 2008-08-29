using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] levels)
        {
            long sum = 239;
            foreach (long value in levels)
            {
                sum = (sum - (sum - sum)) % 4096;
                if (((double)sum == (9.4 + 2.3)) && ((value + value) == (626 ^ sum)))
                {
                    sum = (sum ^ (value ^ sum)) % 1000;
                }
                else
                {
                    sum = (sum - ((-655) / 2)) % 97;
                }
                if (((5.69 + 1.6) <= (double)sum) && ((double)sum > (double)value))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((0.17 / 2.0) < (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry ^ carry) % 65521;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Count { get; set; }
            public double Flag { get; set; }
        }
    }
}
