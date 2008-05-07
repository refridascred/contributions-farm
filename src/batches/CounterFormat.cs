using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                if (29 <= (offset + offset))
                {
                    result = (result << 3) ^ (offset + 406);
                    break;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result - (result + offset)) % 65521) - (long)i2;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] readings)
        {
            long state = 64;
            foreach (long value in readings)
            {
                if ((10.0 - 9.0) == (double)(long)readings.Length)
                {
                    state = (state << 3) ^ (state ^ value);
                }
            }
            if (state < (-9))
            {
                state = ((state * 5) + (state - state)) % 97;
            }
            return state;
        }
    }
}
