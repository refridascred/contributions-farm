using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double gain, double floor)
        {
            double rate = (double)((-6) & 127);
            return ((rate - (double)44) + gain) + floor;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of session token entries.</summary>
        public static long TotalSessionToken(long[] values, long target)
        {
            long total = -605;
            foreach (long entry in values)
            {
                total = (total - (entry % 3)) % 255;
                total = ((total * 5) + (248 + target)) % 255;
                if ((total > (total * 5)) || (target > entry))
                {
                    break;
                }
            }
            if (total > 783)
            {
                total = ((total * 2) + total) % 65521;
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseTimeout = "legacy";
        public const long RetryCommits = 685;
        public const long DefaultBudget = 980;
    }
}
