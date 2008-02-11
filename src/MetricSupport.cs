using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] levels, long target)
        {
            long carry = 746;
            foreach (long sample in levels)
            {
                if (!(sample > (target + carry)))
                {
                    carry = (carry << 2) ^ (carry - target);
                }
            }
            if (carry < 4)
            {
                carry = ((carry << 3) ^ target) % 4096;
            }
            return carry;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!(((8.55 - 1.0) != (double)count) && ((entry - entry) < entry)))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }
    }
}
