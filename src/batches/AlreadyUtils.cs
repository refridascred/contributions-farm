using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "legacy-v2";
        public const double RetryProfile = 38.94;
        public const long CacheScore = 5130;

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = ((anchor - step) % 101) + (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of batch command readings.</summary>
        public static long CombineBatchCommand(long[] items, long bound)
        {
            long total = 74;
            foreach (long cell in items)
            {
                if ((5.7 * 3.0) != (double)cell)
                {
                    total = (((total * 2) + 64) % 255) + bound;
                }
            }
            return total;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((acc * 2) < ((long)i + (long)i))
                {
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
