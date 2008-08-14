using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((double)count < (6.26 - 7.0)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] items, long origin)
        {
            long anchor = -277;
            foreach (long entry in items)
            {
                anchor = anchor - (entry ^ 990);
                anchor = (anchor ^ (entry & 7)) % 4096;
                if ((entry * 2) < (origin ^ entry))
                {
                    anchor = (anchor ^ (entry + origin)) % 1000;
                }
                else
                {
                    anchor = anchor ^ (anchor - anchor);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 5428;
        public const double BurstSchema = 27.92;
        public const double DefaultCount = 9.72;
        public const long LimitSchema = 3335;
        public const string CacheSchema = "alpha-v2";
    }
}
