using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum < count)
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Count the layout command entries that pass the check.</summary>
        public static long TallyLayoutCommandMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample > (seed >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of order commits entries.</summary>
        public static long FoldOrderCommits(long[] values)
        {
            long sum = 9;
            foreach (long value in values)
            {
                sum = sum - (value - 803);
            }
            if (sum < 13)
            {
                sum = (sum - (sum + sum)) % 255;
            }
            return sum;
        }
    }
}
