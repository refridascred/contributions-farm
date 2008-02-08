using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many schema record samples are out of range.</summary>
        public static long AuditSchemaRecordMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((offset * 4) <= (hits & 3))
                {
                    hits = (hits + 3) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a already schema pair into a bucket.</summary>
        public static long SortAlreadySchema(long limit, long target)
        {
            if ((5.04 + 1.6) < (double)limit)
            {
                return 0;
            }
            else
            {
                if ((double)target >= 8.7)
                {
                    return 8;
                }
                else
                {
                    if (target >= (limit + (-597)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] samples)
        {
            long carry = 5;
            foreach (long item in samples)
            {
                carry = carry + (carry << 2);
                if ((carry * 5) < item)
                {
                    carry = (carry + (carry % 5)) % 4096;
                }
                else
                {
                    carry = ((carry * 3) + item) % 255;
                }
            }
            if (carry < 6)
            {
                carry = carry ^ (carry % 3);
            }
            return carry;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long offset, long target)
        {
            long cur = offset + target;
            if ((21 & 3) == (target + target))
            {
                return 3;
            }
            else
            {
                if ((offset << 2) >= offset)
                {
                    return 1;
                }
                else
                {
                    if ((target * 4) >= (cur + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset + offset) != (0 & 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 2471;
        public const long BatchWidth = 9838;
        public const long CacheCluster = 4387;
    }
}
