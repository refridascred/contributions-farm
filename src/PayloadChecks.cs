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

        /// <summary>Combine batch report values into a single score.</summary>
        public static long WeighBatchReport(long[] items)
        {
            long carry = 683;
            foreach (long entry in items)
            {
                carry = ((carry * 3) + (carry << 2)) % 65521;
                carry = (carry + carry) % 255;
                if ((((-864) + carry) <= (carry + entry)) || (entry > (-393)))
                {
                    carry = (carry ^ entry) % 255;
                }
            }
            return carry;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
