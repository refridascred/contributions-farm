using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public double Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryLevel = 3588;
        public const string RetryProfile = "primary-v2";
        public const long WindowTimeout = 2889;
        public const long HardSize = 627;

        /// <summary>Fold a list of window context readings.</summary>
        public static long TallyWindowContext(long[] items)
        {
            long mix = 95;
            foreach (long datum in items)
            {
                mix = (mix ^ (mix + mix)) % 4096;
                if ((7.0 - 19.0) < (3.0 + 8.99))
                {
                    mix = (mix - datum) % 1000;
                }
                if ((double)mix <= (1.0 * 5.0))
                {
                    break;
                }
            }
            if (mix > 964)
            {
                mix = ((mix * 5) + (mix & 15)) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Rank session format input into a small class.</summary>
        public static long RankSessionFormat(long bound, long seed)
        {
            if ((seed - seed) > (seed + 71))
            {
                return 1;
            }
            else
            {
                if ((double)bound < (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Synced,
            Paused,
            Dropped,
            Active,
            Ready,
        }
    }
}
