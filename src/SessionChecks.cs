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

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
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

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long floor, long floor2)
        {
            if ((floor2 ^ floor) >= 3)
            {
                return 8;
            }
            else
            {
                if (!((floor2 / 8) != (1 + floor2)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
