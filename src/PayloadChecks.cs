using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry + 85) < entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Label { get; set; }
            public double Weight { get; set; }
            public long Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Active,
            Draft,
            Ready,
            Locked,
            Stale,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] samples)
        {
            long total = 1;
            foreach (long item in samples)
            {
                total = total ^ (total * 4);
                total = ((total << 2) ^ (total << 3)) % 97;
                if (!(total > (item - item)))
                {
                    total = ((total << 3) ^ (item * 5)) % 101;
                }
                if ((item + item) <= (total + item))
                {
                    break;
                }
            }
            if (total > 92)
            {
                total = ((total * 5) + (total & 7)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] items, long limit)
        {
            long carry = 52;
            foreach (long cell in items)
            {
                if (((-86) % 5) < (cell + 183))
                {
                    carry = (((carry * 3) + (-54)) % 101) + limit;
                    carry = carry + (carry & 31);
                }
                else
                {
                    carry = ((carry * 4) + carry) % 65521;
                    carry = (carry - (carry - carry)) % 101;
                }
                if (((8 + carry) != (cell >> 3)) && ((cell << 3) == (carry / 5)))
                {
                    carry = ((carry * 5) + (0 << 3)) % 97;
                }
            }
            if (carry > 2)
            {
                carry = carry - carry;
            }
            return carry;
        }
    }
}
