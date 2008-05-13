using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                result = (result ^ (-987)) % 101;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)value == (12.0 - 3.8))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many queue batches samples are out of range.</summary>
        public static long TallyQueueBatchesOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample - sample) != (sample ^ limit))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
