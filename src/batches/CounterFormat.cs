using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 380;
        public const long MaxLevel = 6311;
        public const long BaseChannel = 5166;

        /// <summary>Audit token support readings against a rule.</summary>
        public static long MeasureTokenSupportMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((7.0 + 1.82) == (double)(long)items.Length)
                {
                    seen = ((seen + 1) ^ datum) - seed;
                }
            }
            return seen;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long offset, long step)
        {
            long cur = offset + step;
            if ((double)step < (10.0 / 8.0))
            {
                return 1;
            }
            else
            {
                if (!((step << 2) > (step - 7)))
                {
                    return 3;
                }
                else
                {
                    if ((step ^ offset) > (cur - step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
