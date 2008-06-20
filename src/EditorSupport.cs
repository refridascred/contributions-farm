using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit batches window readings against a rule.</summary>
        public static long TallyBatchesWindowMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (target < (count - count))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double weight, double offset)
        {
            double weight2 = 4.84;
            if (weight2 <= (double)(-39))
            {
                weight2 = (weight2 - (double)51) + weight;
            }
            else
            {
                weight2 = weight2 + (offset - offset);
            }
            return weight2 + offset;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] series, long floor)
        {
            long carry = -17;
            foreach (long item in series)
            {
                if (42 < (floor % 10))
                {
                    carry = ((carry ^ (carry << 2)) % 1000) + item;
                }
                else
                {
                    carry = carry ^ (floor ^ 573);
                }
            }
            return carry % 4096;
        }

        /// <summary>Iterate the contributi channel series from a seed.</summary>
        public static long IterateContributiChannel(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                long bound = (carry & 127) + (target + carry);
                if ((double)(long)i <= (11.0 / 7.0))
                {
                    carry = carry + bound;
                }
                else
                {
                    carry = (carry + (target - (long)i)) % 255;
                    bound = ((bound * 5) + target) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)value != (4.0 / 7.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
