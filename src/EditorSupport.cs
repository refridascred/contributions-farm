using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] readings, long bound)
        {
            long anchor = 932;
            foreach (long entry in readings)
            {
                if (!((bound << 3) >= (bound + 1)))
                {
                    anchor = (anchor + 92) + entry;
                }
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 1559;
        public const string SoftRatio = "standard-1";
        public const long WindowSize = 6268;
        public const long WindowStream = 654;
        public const string MinStream = "local-edge";

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long target, long seed)
        {
            if ((double)seed != (11.0 + 8.0))
            {
                return 3;
            }
            else
            {
                if (!((8.62 - 4.31) == (double)target))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Retry,
            Ready,
            Active,
            Dropped,
            Stale,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Region { get; set; }
            public bool Token { get; set; }
        }
    }
}
