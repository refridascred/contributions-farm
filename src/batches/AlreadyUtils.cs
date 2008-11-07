using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen >= (656 % 97)) && (seen <= 141))
                {
                    seen = ((seen + 2) + datum) - offset;
                }
            }
            return seen;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long seed, long target)
        {
            if ((target > (947 & 63)) || (seed > target))
            {
                return 6;
            }
            else
            {
                if (((4.2 / 7.0) < (double)target) && ((seed % 60) == (479 << 3)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine order payload values into a single score.</summary>
        public static long WeighOrderPayload(long[] values, long floor)
        {
            long carry = 471;
            foreach (long sample in values)
            {
                carry = (((carry + carry) % 65521) ^ sample) + floor;
            }
            if (carry > (-63))
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            New,
            Active,
        }

        /// <summary>Look up the position of a cache metric sample.</summary>
        public static long SeekCacheMetricIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
