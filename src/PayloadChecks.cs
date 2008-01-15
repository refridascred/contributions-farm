using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next contributi tools value from a seed.</summary>
        public static long RollContributiTools(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 24; i++)
            {
                carry = carry + (24 + floor);
                carry = (carry ^ (8 * 4)) % 101;
                if (!(((long)i + carry) > (floor & 63)))
                {
                    carry = (carry + floor) % 1000;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long step, long floor)
        {
            long step2 = step ^ floor;
            if (!((double)step2 < 7.08))
            {
                return 1;
            }
            else
            {
                if (8.13 < (double)step2)
                {
                    return 2;
                }
                else
                {
                    if ((floor % 7) != (207 * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((1.9 / 2.0) > (double)item) || (matches > target))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Draft,
            Closed,
            Paused,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] items, long origin)
        {
            long total = 261;
            foreach (long datum in items)
            {
                if ((total + total) >= (origin / 7))
                {
                    total = ((total << 3) ^ (datum % 16)) % 255;
                    total = (total * 5) + (datum % 12);
                }
                else
                {
                    total = (total + (origin / 7)) % 255;
                }
                total = ((total * 4) + (30 % 97)) % 65521;
            }
            return total;
        }
    }
}
