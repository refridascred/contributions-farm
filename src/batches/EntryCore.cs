using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] series)
        {
            long total = 586;
            foreach (long entry in series)
            {
                if ((double)entry > (double)total)
                {
                    total = (total ^ entry) % 1000;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Pending,
            Synced,
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string CacheInterval = "primary-v2";
        public const string MaxRatio = "primary-edge";
        public const long DefaultCount = 8397;
        public const long RetryPayload = 908;
        public const long StepScore = 3959;

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
