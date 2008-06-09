using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((hits + sample) <= (hits + hits)) && ((2.42 * 13.0) > (double)sample)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batch schema samples.</summary>
        public static long TallyBatchSchema(long[] samples, long limit)
        {
            long anchor = 351;
            foreach (long cell in samples)
            {
                if ((double)anchor != (double)197)
                {
                    anchor = (anchor << 2) ^ limit;
                }
                anchor = (anchor - (cell >> 2)) % 97;
            }
            if (anchor < 9)
            {
                anchor = (anchor ^ (anchor - limit)) % 97;
            }
            return anchor;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)floor != (double)620)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
