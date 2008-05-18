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

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double bias, double offset)
        {
            double weight = bias / 5.0;
            if (weight > (weight - offset))
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + offset) - (double)(long)i;
            }
            return weight + bias;
        }
    }
}
