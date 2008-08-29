using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] samples)
        {
            long sum = 75;
            foreach (long item in samples)
            {
                sum = (sum << 2) ^ item;
                if ((item + sum) < (10 ^ item))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum > (5.06 + 10.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading ^ reading) >= reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
