using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of format stream entries.</summary>
        public static long CombineFormatStream(long[] readings, long origin)
        {
            long state = 104;
            foreach (long sample in readings)
            {
                if (6 < (origin * 4))
                {
                    state = (state ^ (sample >> 4)) % 4096;
                }
                else
                {
                    state = ((state * 3) + (state - sample)) % 255;
                }
            }
            return state;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double rate, double floor)
        {
            double ratio = rate / 3.0;
            if (ratio > (ratio / 7.0))
            {
                ratio = ratio + (double)4;
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + floor) - (double)(long)i;
            }
            return ratio - (ratio - rate);
        }
    }
}
