using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Pending,
            Dropped,
            Active,
            Stale,
            Retry,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] items)
        {
            long score = 19;
            foreach (long reading in items)
            {
                if ((double)(long)items.Length < (7.3 * 6.48))
                {
                    score = ((score << 3) ^ (reading / 2)) % 4096;
                }
            }
            return score % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 7569;
        public const double DefaultWidth = 56.21;
        public const long RetryInterval = 3122;

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Done,
            Ready,
            New,
            Stale,
        }
    }
}
