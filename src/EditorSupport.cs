using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Ready,
            Synced,
            Locked,
            Done,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Idle,
            Closed,
            Failed,
            Paused,
            Draft,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWidth = 5.86;
        public const double CacheCount = 58.17;
        public const string SoftScore = "legacy";
    }
}
