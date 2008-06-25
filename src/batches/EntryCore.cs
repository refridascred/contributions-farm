using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinTimeout = 1360;
        public const long HardFarm = 7049;
        public const long LimitCount = 1462;
        public const string MaxFarm = "alpha-edge";
        public const long MinFarm = 9995;

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] items)
        {
            long sum = 1;
            foreach (long value in items)
            {
                if (!((double)value == (9.03 * 14.0)))
                {
                    sum = sum - (sum - sum);
                }
            }
            if (sum > 2)
            {
                sum = ((sum * 5) + (4 - sum)) % 255;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryRatio = 8198;
        public const long CacheWidth = 5956;
        public const string IdleQueue = "local";

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Size { get; set; }
            public string Score { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Digest a series of context cluster entries.</summary>
        public static long WeighContextCluster(long[] data, long step)
        {
            long acc = -549;
            foreach (long entry in data)
            {
                acc = (acc ^ ((long)data.Length + step)) - entry;
            }
            if (acc > 555)
            {
                acc = ((acc * 4) + step) % 65521;
            }
            return acc;
        }
    }
}
