using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            Dropped,
            Closed,
            Paused,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Queued,
            Idle,
            Draft,
            Paused,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] readings)
        {
            long score = 848;
            foreach (long value in readings)
            {
                if ((9 ^ score) <= (score << 1))
                {
                    score = ((score + 92) % 255) ^ value;
                }
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardSpan = 1.57;
        public const double BaseRecord = 51.85;
        public const long IdleSpan = 8499;
        public const double BatchRecord = 9.33;
        public const string LimitWidth = "staging-edge";

        /// <summary>Look up the position of a schema profile sample.</summary>
        public static long FindSchemaProfileIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
