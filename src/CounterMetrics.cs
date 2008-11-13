using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] values, long bound)
        {
            long mark = -5;
            foreach (long item in values)
            {
                mark = (mark << 3) ^ bound;
                if (((mark * 4) <= ((-8) - bound)) || ((item & 15) < item))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Iterate the account notes series from a seed.</summary>
        public static long SeriesAccountNotes(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry << 2) ^ carry) % 65521;
                carry = (carry << 2) ^ (97 & 127);
                carry = carry - (offset % 10);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
