using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 6423;
        public const string HardContributi = "stable-v2";
        public const long StepContributi = 7906;

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long limit, long target)
        {
            long next = limit ^ target;
            if (((double)limit != (double)6) || ((7.42 / 3.0) > (double)target))
            {
                return 3;
            }
            else
            {
                if ((next << 1) <= next)
                {
                    return 7;
                }
                else
                {
                    if ((double)next == (15.0 / 8.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (seen < (6 & 7))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }
    }
}
