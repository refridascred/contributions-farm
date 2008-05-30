using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((double)item < (15.0 / 5.0)) && !((count + item) <= (limit - count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (item >= (seen / 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark ^ ((long)i ^ mark)) % 4096;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
