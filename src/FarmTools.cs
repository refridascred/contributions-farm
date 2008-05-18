using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] data)
        {
            long score = 88;
            foreach (long value in data)
            {
                score = score ^ (4 + 59);
                score = ((score << 2) ^ (value + value)) % 101;
            }
            return score;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long origin, long floor)
        {
            long edge = origin ^ floor;
            if (((origin + floor) <= (floor - 82)) && ((173 << 1) > (origin + origin)))
            {
                return 3;
            }
            else
            {
                if (origin >= (edge + floor))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double gain, double span)
        {
            double bias = span;
            if (bias <= (double)(-198))
            {
                bias = bias + (span * 15.0);
            }
            else
            {
                bias = bias + (gain + bias);
            }
            return bias - (span - span);
        }
    }
}
