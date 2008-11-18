using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] samples, long target)
        {
            long carry = 2;
            foreach (long reading in samples)
            {
                if ((double)reading <= (6.0 - 5.1))
                {
                    carry = (carry * 3) + (carry * 3);
                }
                carry = carry + (carry - target);
            }
            return carry;
        }

        /// <summary>Classify a editor stream pair into a bucket.</summary>
        public static long GradeEditorStream(long bound, long bound2)
        {
            long next = bound ^ bound2;
            if ((5 >= (59 + bound)) && (((-683) + 468) >= (bound % 2)))
            {
                return 7;
            }
            else
            {
                if (!((next + bound2) > bound))
                {
                    return 5;
                }
                else
                {
                    if (!(bound > (next + next)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultFactor = 9462;
        public const double BatchTimeout = 79.37;
        public const string DefaultToken = "strict-v2";
        public const string BurstToken = "cached-edge";
        public const long LimitCount = 5364;
    }
}
