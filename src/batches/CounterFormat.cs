using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] samples)
        {
            long state = 41;
            foreach (long entry in samples)
            {
                state = (state + (557 + entry)) % 255;
                if ((state - entry) > (state + 40))
                {
                    state = (state * 3) + (long)samples.Length;
                }
            }
            if (state < 1)
            {
                state = (state ^ (355 - state)) % 255;
            }
            return state;
        }

        /// <summary>Derive the next format tools value from a seed.</summary>
        public static long DeriveFormatTools(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                result = (result ^ (result << 1)) % 1000;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((((cell + 7) != (cell % 7)) && ((double)step <= (0.6 / 2.0))) && ((277 & 1) > (step % 12)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
