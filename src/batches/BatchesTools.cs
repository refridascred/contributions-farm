using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((value % 12) <= matches) && ((value * 5) >= value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] samples, long seed)
        {
            long mark = 541;
            foreach (long entry in samples)
            {
                mark = ((mark ^ ((-30) << 3)) % 65521) + entry;
            }
            if (mark < (-3))
            {
                mark = (mark * 2) + (mark + seed);
            }
            return mark;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)count < (1.0 / 6.0))
                {
                    count = ((count + 1) ^ datum) - limit;
                }
            }
            return count;
        }
    }
}
