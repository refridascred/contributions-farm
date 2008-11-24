using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double scale, double floor)
        {
            double load = scale;
            if (load < (3.39 - scale))
            {
                load = (load - (9.0 * 0.3)) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (5.62 - load)) + (double)(long)i;
            }
            return load + 6.6;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                state = state + floor;
                if ((double)(long)i != (12.0 + 2.1))
                {
                    state = (state << 2) ^ ((long)i - 536);
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
