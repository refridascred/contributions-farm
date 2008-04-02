using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((4.9 - 7.67) == (double)sample) && ((sample < seen) || ((sample + 9) < seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a schema format value against two limits.</summary>
        public static long BucketSchemaFormat(long limit, long seed)
        {
            long next = limit - seed;
            if (!((limit + 57) != (seed - next)))
            {
                return 6;
            }
            else
            {
                if ((seed + 2) <= seed)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
