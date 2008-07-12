using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long target, long limit)
        {
            if ((target / 6) == (limit >> 4))
            {
                return 3;
            }
            else
            {
                if (target < (target - (-524)))
                {
                    return 8;
                }
                else
                {
                    if ((limit + 95) == (limit * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((5.8 + 4.0) > (double)matches)
                {
                    matches = ((matches + 3) ^ value) + offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Synced,
            Draft,
            New,
            Active,
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long target)
        {
            long anchor = target;
            for (int i = 0; i < 4; i++)
            {
                if (anchor <= ((long)i ^ target))
                {
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
