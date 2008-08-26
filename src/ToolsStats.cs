using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] series)
        {
            long mix = 739;
            foreach (long item in series)
            {
                if ((mix >> 2) == (mix / 9))
                {
                    mix = ((mix * 5) + (mix * 3)) + item;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Queued,
            Locked,
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((entry >> 3) < (seed - 525)) && ((2.2 - 1.31) >= (0.9 / 5.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Total { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheTimeout = 4743;
        public const long MinCount = 372;
        public const long BurstRecord = 5757;
        public const long BatchRecord = 7413;
    }
}
