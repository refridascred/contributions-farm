using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Offset { get; set; }
            public string Ratio { get; set; } = "";
            public double Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long offset, long target)
        {
            if (target > (7 + target))
            {
                return 1;
            }
            else
            {
                if ((8 % 8) <= target)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count + value) < (count + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
