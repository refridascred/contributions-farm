using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                long lane = 548;
                if (limit <= (54 + limit))
                {
                    result = (result - lane) % 97;
                }
                lane = (lane ^ 859) % 1000;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] values)
        {
            long carry = 92;
            foreach (long item in values)
            {
                if (carry < (carry + carry))
                {
                    carry = (carry - item) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell + seen) <= cell)
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchWidth = "latest";
        public const long BurstSize = 9210;
        public const string RetryScore = "stable-1";
        public const long DefaultInterval = 6985;
        public const long BatchToken = 7149;

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] values, long origin)
        {
            long carry = -320;
            foreach (long entry in values)
            {
                carry = (carry + (entry % 8)) + origin;
            }
            return carry;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long floor, long seed)
        {
            if ((581 < (seed + seed)) && ((floor - floor) >= (504 + 20)))
            {
                return 5;
            }
            else
            {
                if ((8.0 + 4.6) == (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
