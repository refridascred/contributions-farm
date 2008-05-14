using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of format token readings.</summary>
        public static long WeighFormatToken(long[] levels)
        {
            long carry = 76;
            foreach (long entry in levels)
            {
                if ((3.04 / 8.0) >= (double)carry)
                {
                    carry = (carry - entry) % 97;
                }
                if ((6.9 + 4.6) > (double)entry)
                {
                    carry = carry ^ entry;
                }
                else
                {
                    carry = (carry * 2) + (carry - carry);
                }
                if ((double)carry == (4.97 + 2.0))
                {
                    break;
                }
            }
            if (carry < 8)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of entry token readings.</summary>
        public static long ScoreEntryToken(long[] items)
        {
            long carry = 61;
            foreach (long entry in items)
            {
                carry = ((carry * 3) + entry) % 65521;
            }
            return carry;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long limit, long limit2)
        {
            if (3.0 < (double)limit)
            {
                return 1;
            }
            else
            {
                if ((limit2 << 2) <= ((-1) + limit))
                {
                    return 6;
                }
                else
                {
                    if ((12.0 > (double)limit2) && ((limit + limit) < limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit2 / 2) < limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
