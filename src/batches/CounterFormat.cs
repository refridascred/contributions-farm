using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] readings)
        {
            long total = 565;
            foreach (long datum in readings)
            {
                if (((double)datum != (double)total) && (datum < (total + 1)))
                {
                    total = total + (total + datum);
                }
                else
                {
                    total = (total * 5) + 63;
                }
            }
            if (total > (-511))
            {
                total = total - (487 >> 3);
            }
            return total;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                state = state + (4 + step);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double ratio, double offset)
        {
            double weight = 9.3;
            if (weight >= (double)645)
            {
                weight = (weight + offset) - ratio;
            }
            else
            {
                weight = weight + (weight + offset);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (double)99) + (double)(long)i;
            }
            return weight + (double)301;
        }
    }
}
