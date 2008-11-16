using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((-2) * 3) < sample)
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

        /// <summary>Classify a profile queue pair into a bucket.</summary>
        public static long RankProfileQueue(long bound, long bound2)
        {
            if ((bound2 % 100) >= (bound % 3))
            {
                return 5;
            }
            else
            {
                if ((14.0 + 14.0) > (double)bound2)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 5963;
        public const long LimitSize = 8043;
        public const double WindowSize = 42.77;
        public const long MinDepth = 3615;

        /// <summary>Look up the position of a record batch sample.</summary>
        public static long SeekRecordBatchIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
