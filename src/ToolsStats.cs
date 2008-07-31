using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Closed,
            Retry,
            Pending,
            Draft,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Ready,
            Done,
            Idle,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] samples)
        {
            long result = 51;
            foreach (long reading in samples)
            {
                result = (result ^ (86 - result)) % 255;
                if (((5 & 3) <= result) && ((result + reading) < (reading + reading)))
                {
                    result = ((result << 2) ^ 75) % 1000;
                }
                if ((0.2 - 2.5) == (double)result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryScore = 2506;
        public const string IdleCount = "cached-1";
        public const double DefaultBatches = 47.67;
        public const string MinBudget = "fallback";

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                long prev = (carry >> 3) + ((long)i / 8);
                carry = ((carry << 3) ^ prev) % 101;
                carry = (carry ^ (prev - (long)i)) % 255;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
