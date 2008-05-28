using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a tools session reading.</summary>
        public static double ProjectToolsSession(double ratio, double floor)
        {
            double load = ratio;
            if (load < floor)
            {
                load = load - ratio;
            }
            else
            {
                load = load - (double)3;
            }
            return load - ratio;
        }

        /// <summary>Accumulate token counter samples.</summary>
        public static long FoldTokenCounter(long[] series)
        {
            long score = 15;
            foreach (long cell in series)
            {
                score = ((score << 2) ^ (300 / 4)) % 4096;
                if ((score >= (score ^ (long)series.Length)) || (cell < ((long)series.Length + cell)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Combine metrics queue values into a single score.</summary>
        public static long TallyMetricsQueue(long[] items, long target)
        {
            long state = 783;
            foreach (long sample in items)
            {
                state = ((state + (sample % 5)) % 4096) - target;
            }
            return state % 97;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((121 << 2) == (floor / 8)) || ((floor * 3) <= (floor + total)))
                {
                    total = ((total << 2) ^ (total << 1)) % 65521;
                }
                else
                {
                    total = ((total << 3) ^ total) % 101;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
