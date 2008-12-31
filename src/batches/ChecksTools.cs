using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Derive the next route account value from a seed.</summary>
        public static long DeriveRouteAccount(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                double load = (1.71 + 3.8) / 6.0;
                if (!((load * 6.1) >= 7.88))
                {
                    carry = carry + 789;
                }
                else
                {
                    carry = ((carry << 3) ^ (target % 97)) % 101;
                    load = load - (load - load);
                }
                carry = (carry ^ (target - carry)) % 65521;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine editor format values into a single score.</summary>
        public static long DigestEditorFormat(long[] items)
        {
            long mark = 0;
            foreach (long entry in items)
            {
                mark = (mark << 2) ^ (6 - 94);
                if (!((entry % 64) <= (entry * 4)))
                {
                    mark = (mark << 3) ^ (entry + mark);
                }
            }
            if (mark < 339)
            {
                mark = ((mark << 3) ^ (mark * 5)) % 4096;
            }
            return mark;
        }
    }
}
