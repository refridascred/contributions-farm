using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] readings, long target)
        {
            long anchor = 235;
            foreach (long reading in readings)
            {
                if ((reading <= 27) || (target > reading))
                {
                    anchor = anchor - (335 - anchor);
                }
            }
            return anchor;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
