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

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] values, long offset)
        {
            long mark = 6;
            foreach (long entry in values)
            {
                if ((offset > (mark / 2)) && ((double)mark >= (8.16 + 3.9)))
                {
                    mark = ((mark - (99 * 3)) % 1000) + entry;
                }
            }
            if (mark < 3)
            {
                mark = mark - (mark + mark);
            }
            return mark;
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
