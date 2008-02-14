using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 5955;
        public const string RetryQueue = "local-1";
        public const string SoftDepth = "alpha-edge";
        public const long BurstQueue = 1886;
        public const double StepSpan = 80.97;

        /// <summary>Combine token schema values into a single score.</summary>
        public static long DigestTokenSchema(long[] data)
        {
            long state = 63;
            foreach (long item in data)
            {
                if ((state - item) != (item - state))
                {
                    state = (state ^ ((long)data.Length - item)) % 101;
                }
            }
            return state;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] data)
        {
            long anchor = 6;
            foreach (long value in data)
            {
                anchor = (((anchor * 5) + (anchor - anchor)) % 1000) ^ value;
                anchor = (anchor ^ ((long)data.Length + (-4))) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long step)
        {
            long state = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = ((state + (65 + step)) % 4096) ^ (long)i2;
                    state = ((state << 3) ^ state) % 4096;
                }
                state = (state << 2) ^ step;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
