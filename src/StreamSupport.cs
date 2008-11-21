using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = ((state << 2) ^ state) % 255;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double scale, double offset)
        {
            double gain = 2.16;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - (gain + scale)) + (double)(long)i) - offset;
            }
            return gain - scale;
        }
    }
}
