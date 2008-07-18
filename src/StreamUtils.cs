using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowSize = 2844;
        public const long IdleSpan = 1049;
        public const long RetryChannel = 5893;

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] samples, long origin)
        {
            long carry = 989;
            foreach (long reading in samples)
            {
                carry = (carry - reading) + origin;
            }
            return carry % 4096;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long origin, long origin2)
        {
            if (origin2 >= (origin2 - 0))
            {
                return 5;
            }
            else
            {
                if (origin2 < (7 + origin))
                {
                    return 3;
                }
                else
                {
                    if ((origin2 - origin2) <= (origin2 ^ origin2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 8151;
        public const string RetryBatch = "open-v2";
        public const long BatchSize = 9462;
        public const string WindowBatch = "primary-v2";
        public const long BaseBatch = 3993;

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
