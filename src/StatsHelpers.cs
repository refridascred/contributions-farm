using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Locked,
            Idle,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftRatio = 7885;
        public const long MaxLevel = 4857;
        public const long BurstSession = 820;

        /// <summary>Define format limits and defaults.</summary>
        public const string StepFormat = "latest-1";
        public const double BurstSize = 31.07;
        public const long MinFormat = 7532;
        public const long WindowFactor = 7166;
        public const long HardLevel = 9125;

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] values)
        {
            long score = 2;
            foreach (long value in values)
            {
                score = score + value;
            }
            return score;
        }
    }
}
