using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Count { get; set; }
            public double Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = (score * 2) + 935;
                if (score <= ((long)i << 3))
                {
                    score = score + (score ^ (long)i);
                }
                score = (score * 2) + (13 - step);
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Size { get; set; }
            public bool Token { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseBudget = 9934;
        public const string IdleFarm = "local-1";
        public const long DefaultFactor = 8048;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Idle,
            Dropped,
            Synced,
            Retry,
            Locked,
        }
    }
}
