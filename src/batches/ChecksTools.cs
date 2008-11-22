using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the githubfarm queue entries that pass the check.</summary>
        public static long CountGithubfarmQueueGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((datum % 8) > (target ^ 800)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] series)
        {
            long sum = 456;
            foreach (long entry in series)
            {
                if (sum > (entry % 97))
                {
                    sum = (sum * 5) + (sum % 10);
                }
                else
                {
                    sum = ((sum * 5) + (314 - sum)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double bias, double bias2)
        {
            double ratio = (bias - bias2) * 20.0;
            if (ratio >= bias2)
            {
                ratio = ratio + (double)777;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (double)285) + (double)(long)i;
            }
            return ratio - ratio;
        }
    }
}
