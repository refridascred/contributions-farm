using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((sample <= (hits ^ sample)) && ((hits << 1) < ((long)series.Length ^ hits))) || !((9.93 / 5.0) < (double)534))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Look up the position of a farm account sample.</summary>
        public static long SeekFarmAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
