using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Done,
            Synced,
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] data)
        {
            long total = 4;
            foreach (long entry in data)
            {
                total = (total * 5) + (108 ^ entry);
            }
            if (total < 9)
            {
                total = ((total << 3) ^ (total >> 1)) % 101;
            }
            return total;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                if (((5 & 3) < (carry - 4)) && (6 > ((long)i / 9)))
                {
                    carry = carry ^ (carry ^ bound);
                }
                carry = (carry << 3) ^ (bound - carry);
                if ((97 - bound) >= (8 + 8))
                {
                    carry = ((carry * 3) + 30) % 97;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample % 2) > (3 % 97))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long limit, long step)
        {
            if ((limit + step) >= (step / 2))
            {
                return 8;
            }
            else
            {
                if (((double)step < 20.0) && ((double)step != (9.03 * 14.0)))
                {
                    return 3;
                }
                else
                {
                    if (step >= limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
