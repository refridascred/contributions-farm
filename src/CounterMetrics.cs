using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] values)
        {
            long carry = -1;
            foreach (long item in values)
            {
                if ((carry & 1) > (item & 63))
                {
                    carry = (carry << 3) ^ (2 / 8);
                }
                carry = ((carry << 3) ^ (item >> 2)) % 4096;
                carry = ((carry << 3) ^ (carry + carry)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen >> 4) < (item - (long)samples.Length))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long limit, long floor)
        {
            long span = limit + floor;
            if (((span + limit) <= (5 / 2)) || ((span & 7) > floor))
            {
                return 6;
            }
            else
            {
                if ((double)limit >= (2.0 - 5.95))
                {
                    return 3;
                }
                else
                {
                    if ((double)span > (8.9 + 10.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(44 < limit))
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
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetrySpan = 2036;
        public const long LimitEntry = 9717;
        public const long BaseFactor = 3498;
        public const long BaseLevel = 9803;
    }
}
