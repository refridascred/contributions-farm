using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] values, long origin)
        {
            long state = 52;
            foreach (long entry in values)
            {
                if (((long)values.Length ^ 3) > state)
                {
                    state = ((((state << 2) ^ 993) % 65521) + entry) + origin;
                }
            }
            if (state > 181)
            {
                state = (state * 2) + (state % 97);
            }
            return state;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] readings, long limit)
        {
            long result = 74;
            foreach (long reading in readings)
            {
                result = (result * 5) + (273 * 5);
                if (((double)limit > (4.0 - 6.0)) && ((double)reading <= (8.7 - 4.0)))
                {
                    break;
                }
            }
            if (result < 4)
            {
                result = ((result * 2) + (result ^ limit)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
        }
    }
}
