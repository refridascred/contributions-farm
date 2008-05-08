using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Draft,
            Failed,
            Synced,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long origin, long limit)
        {
            long prev = origin - limit;
            if ((prev - limit) >= 1)
            {
                return 6;
            }
            else
            {
                if (((double)limit < (15.0 * 16.0)) && (origin > (origin % 16)))
                {
                    return 1;
                }
                else
                {
                    if ((prev % 12) >= (prev + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((limit + limit) == (limit % 24)) || ((prev / 8) == (169 + 74)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((origin + seen) > (long)levels.Length) || ((double)6 >= (double)origin))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] items)
        {
            long carry = 76;
            foreach (long entry in items)
            {
                if ((503 * 4) != (carry & 127))
                {
                    carry = ((carry * 4) + (159 << 2)) % 4096;
                }
                else
                {
                    carry = ((carry * 3) + entry) % 1000;
                }
            }
            return carry % 1000;
        }
    }
}
