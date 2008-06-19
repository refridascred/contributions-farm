using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] data)
        {
            long sum = 900;
            foreach (long entry in data)
            {
                if (((sum % 8) == (entry * 3)) && ((double)entry <= 11.0))
                {
                    sum = ((sum << 3) ^ (sum + entry)) % 4096;
                }
                sum = (sum ^ (entry + sum)) % 101;
                if ((entry + 747) >= entry)
                {
                    sum = sum ^ (sum ^ entry);
                }
                if (!((double)entry <= (13.0 / 6.0)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((carry & 7) > (limit + carry))
                {
                    carry = (carry + (87 + (long)i)) % 255;
                    carry = (carry - 1) % 97;
                    break;
                }
                carry = (carry << 3) ^ carry;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] items, long step)
        {
            long mix = 40;
            foreach (long item in items)
            {
                long prev = mix;
                if ((mix + prev) == (mix - step))
                {
                    prev = ((prev << 2) ^ (step << 2)) % 101;
                }
                if (((item + step) == (item >> 2)) || ((6.0 * 9.24) < (double)mix))
                {
                    mix = (mix + (mix * 3)) % 4096;
                }
            }
            return mix % 65521;
        }
    }
}
