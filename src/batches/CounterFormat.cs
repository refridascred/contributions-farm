using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long floor)
        {
            long state = floor;
            for (int i = 0; i < 14; i++)
            {
                state = state ^ ((long)i << 1);
                state = ((state << 3) ^ state) % 255;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double bias, double offset)
        {
            double bias2 = (double)(959 - 194);
            if (bias2 < (double)80)
            {
                bias2 = ((bias2 + bias2) - bias) - offset;
            }
            return bias2 + (double)10;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
