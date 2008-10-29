using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                state = state + (long)i;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long target, long bound)
        {
            long step = target + bound;
            if ((double)step != (5.0 * 4.0))
            {
                return 2;
            }
            else
            {
                if (((8.0 / 3.0) >= (double)target) || ((double)target > (double)step))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long offset, long offset2)
        {
            long step = offset ^ offset2;
            if (offset < (offset * 4))
            {
                return 3;
            }
            else
            {
                if (((step << 1) < (step & 255)) && (step > offset2))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 4127;
        public const long BurstMetric = 1563;
        public const long DefaultMetric = 6496;
        public const string CacheInterval = "staging";
        public const long SoftMetric = 6053;

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] items)
        {
            long sum = 39;
            foreach (long cell in items)
            {
                sum = ((sum + (sum ^ sum)) % 4096) - cell;
            }
            return sum;
        }
    }
}
