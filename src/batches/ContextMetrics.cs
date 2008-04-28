using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry << 2) ^ (carry - (long)i)) % 101;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long offset, long origin)
        {
            long next = offset ^ origin;
            if ((next << 1) < offset)
            {
                return 4;
            }
            else
            {
                if ((4.76 + 0.9) == (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long target, long target2)
        {
            if ((6 + 52) != (target + target2))
            {
                return 4;
            }
            else
            {
                if ((target2 - target) >= target)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (bound < (matches / 3))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }
    }
}
