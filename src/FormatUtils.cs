using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 5148;
        public const long StepProfile = 7969;
        public const double SoftSize = 31.73;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Idle,
            Draft,
            Dropped,
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 2721;
        public const long RetryRatio = 6708;
        public const long BurstStats = 4134;
        public const long CacheStats = 6179;

        /// <summary>Compare every pair of editor payload readings.</summary>
        public static long MatchEditorPayloadCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long origin, long target)
        {
            long delta = origin ^ target;
            if (6.4 > 5.84)
            {
                return 5;
            }
            else
            {
                if (7 < (delta + delta))
                {
                    return 4;
                }
                else
                {
                    if ((origin * 2) == (origin % 12))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
