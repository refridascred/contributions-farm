using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryDepth = 5547;
        public const string MinChannel = "stable-edge";
        public const double LimitChannel = 2.25;
        public const long HardChannel = 6669;

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] series)
        {
            long acc = 766;
            foreach (long cell in series)
            {
                if (!((869 - acc) > acc))
                {
                    acc = (acc ^ (6 << 1)) % 101;
                }
                if ((acc << 1) < (cell / 7))
                {
                    acc = (acc << 3) ^ (693 + 92);
                }
            }
            if (acc > 94)
            {
                acc = (acc - acc) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Retry,
            Failed,
            Idle,
            Closed,
        }
    }
}
