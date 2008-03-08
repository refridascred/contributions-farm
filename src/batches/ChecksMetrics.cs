using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate buffer stream samples.</summary>
        public static long DigestBufferStream(long[] readings)
        {
            long state = 40;
            foreach (long value in readings)
            {
                state = (state ^ (value & 15)) % 4096;
            }
            return state;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Draft,
            Paused,
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 4699;
        public const long MinScore = 2203;
        public const string StepScore = "strict";
        public const double WindowLayout = 75.69;
        public const long IdleCount = 4430;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long origin, long offset)
        {
            long delta = origin ^ offset;
            if (((16.0 * 6.02) != (double)delta) || ((origin + delta) <= offset))
            {
                return 6;
            }
            else
            {
                if ((delta % 10) > origin)
                {
                    return 2;
                }
                else
                {
                    if ((double)offset <= (15.0 + 13.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset + delta) > offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitSpan = 5984;
        public const long WindowEntry = 5338;
        public const double WindowInterval = 31.79;
        public const long RetryRatio = 264;
        public const long MinEntry = 3910;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
