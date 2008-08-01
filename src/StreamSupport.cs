using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] values, long origin)
        {
            long carry = -829;
            foreach (long datum in values)
            {
                if ((datum + carry) < (8 + datum))
                {
                    carry = ((carry * 2) + (origin + datum)) % 1000;
                }
            }
            return carry % 97;
        }

        /// <summary>Validate notes metric readings against a bound.</summary>
        public static bool CheckNotesMetricRange(long[] data, long target)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long seed, long floor)
        {
            if ((6.9 / 7.0) == (double)floor)
            {
                return 4;
            }
            else
            {
                if ((floor - floor) < floor)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
