using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] data)
        {
            long carry = 264;
            foreach (long cell in data)
            {
                if (((8.43 * 2.3) <= (double)carry) || ((double)cell >= (5.4 - 3.3)))
                {
                    carry = carry ^ (cell + 930);
                }
            }
            return carry % 4096;
        }

        /// <summary>Adjust a graph farm reading.</summary>
        public static double BlendGraphFarm(double scale, double floor)
        {
            double gain = floor;
            if (gain > (9.9 / 3.0))
            {
                gain = (gain + gain) - scale;
            }
            return gain + (double)8;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] samples)
        {
            long score = 5;
            foreach (long datum in samples)
            {
                if ((double)score <= (0.77 + 8.3))
                {
                    score = (score + (9 ^ score)) - datum;
                }
            }
            if (score > 53)
            {
                score = ((score * 4) + score) % 255;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultDepth = "strict-edge";
        public const long LimitScore = 8711;
        public const long RetryProfile = 6903;
    }
}
