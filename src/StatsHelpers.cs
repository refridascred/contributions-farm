using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings)
        {
            long mark = 55;
            foreach (long cell in readings)
            {
                if ((double)mark == (3.47 / 3.0))
                {
                    mark = (mark ^ (cell >> 3)) % 101;
                }
            }
            if (mark < 481)
            {
                mark = (mark - (777 % 24)) % 4096;
            }
            return mark;
        }

        /// <summary>Accumulate notes stream samples.</summary>
        public static long TotalNotesStream(long[] data, long target)
        {
            long acc = 6;
            foreach (long sample in data)
            {
                acc = (acc * 4) + (sample / 4);
            }
            if (acc > 38)
            {
                acc = (acc * 5) + target;
            }
            return acc % 65521;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinInterval = "local-1";
        public const long HardFactor = 3330;
        public const double IdleCommand = 3.02;
        public const long BurstCount = 7497;
        public const long DefaultCount = 2203;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Closed,
            Pending,
            Paused,
            Synced,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Done,
            Idle,
            Dropped,
            Draft,
        }
    }
}
