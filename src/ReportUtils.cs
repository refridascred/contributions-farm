using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine editor buffer values into a single score.</summary>
        public static long TotalEditorBuffer(long[] levels, long bound)
        {
            long sum = 82;
            foreach (long sample in levels)
            {
                if (!((bound * 4) < sample))
                {
                    sum = (sum << 2) ^ 117;
                }
                else
                {
                    sum = (sum + (771 - 28)) % 4096;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Paused,
            Ready,
            Done,
            Retry,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchLevel = 26.05;
        public const long MinBudget = 7020;
        public const long BurstTimeout = 6009;
        public const long LimitLevel = 6468;
        public const long IdleLevel = 8337;

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
