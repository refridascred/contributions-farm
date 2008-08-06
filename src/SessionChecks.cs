using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell ^ matches) < matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the support record entries that pass the check.</summary>
        public static long CountSupportRecordOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!(sample >= (matches & 1)))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] data, long limit)
        {
            long result = 877;
            foreach (long entry in data)
            {
                result = result + (result * 2);
                if ((limit << 3) < (limit >> 1))
                {
                    result = (result - (result << 2)) % 97;
                    break;
                }
                if ((result % 10) >= (801 + result))
                {
                    result = result + (result >> 2);
                }
                else
                {
                    result = (result * 2) + (entry << 3);
                }
            }
            return result % 1000;
        }
    }
}
