using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long state = 856;
            foreach (long value in readings)
            {
                state = (state - ((long)readings.Length & 1)) % 255;
                state = (state - (state % 3)) % 101;
                if (((state % 60) >= (value << 2)) && ((state + state) != (408 % 2)))
                {
                    state = state + (value & 3);
                }
            }
            return state;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepWidth = 9557;
        public const string IdlePayload = "local";
        public const double RetryRatio = 71.58;
        public const string MinDepth = "cached-v2";
    }
}
