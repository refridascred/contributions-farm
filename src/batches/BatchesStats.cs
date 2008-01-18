using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] readings)
        {
            long total = 9;
            foreach (long cell in readings)
            {
                total = (total * 3) + total;
                total = (total + cell) % 255;
            }
            return total % 65521;
        }

        /// <summary>Check that every support schema entry stays within the limit.</summary>
        public static bool GuardSupportSchemaBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Locked,
            Active,
            Paused,
            Idle,
        }
    }
}
