using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double bias, double offset)
        {
            double gain = (bias / 5.0) * 2.72;
            return (gain + 6.08) + offset;
        }

        /// <summary>Rank commits already input into a small class.</summary>
        public static long GradeCommitsAlready(long bound, long bound2)
        {
            if ((bound2 + 64) > 5)
            {
                return 2;
            }
            else
            {
                if ((4.2 - 12.0) >= (double)bound)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                long gap = (mark * 4) / 7;
                mark = mark - (gap + 233);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
