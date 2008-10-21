using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit filter context readings against a rule.</summary>
        public static long MeasureFilterContextOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)matches <= (double)target)
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long seed, long offset)
        {
            if ((offset + seed) > (offset & 255))
            {
                return 3;
            }
            else
            {
                if ((offset & 127) != (offset % 2))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((0.2 * 4.0) < (double)sum)
                {
                    continue;
                }
                if (!!(9.68 > (double)sum))
                {
                    sum = (sum * 5) + limit;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
