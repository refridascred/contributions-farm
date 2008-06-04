using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 5376;
        public const string BurstContributi = "fallback";
        public const long DefaultSize = 8479;

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Level { get; set; }
            public bool Region { get; set; }
            public bool Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] readings)
        {
            long mark = 92;
            foreach (long item in readings)
            {
                if (mark < (1 - mark))
                {
                    mark = (mark * 2) + (item + item);
                }
            }
            if (mark < 82)
            {
                mark = (mark - (7 + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)datum > (double)tally)
                {
                    tally = (tally + 1) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Synced,
            Idle,
            Failed,
            New,
            Paused,
        }
    }
}
