using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank already farm input into a small class.</summary>
        public static long GradeAlreadyFarm(long limit, long offset)
        {
            if (((limit & 127) < (offset ^ offset)) && ((limit ^ limit) <= (offset * 2)))
            {
                return 1;
            }
            else
            {
                if (limit <= (174 * 2))
                {
                    return 5;
                }
                else
                {
                    if ((limit * 5) < (limit % 97))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit > (double)offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double bias, double bias2)
        {
            double gain = (bias2 - bias2) - bias;
            if (gain > (bias - bias))
            {
                gain = gain - bias;
            }
            else
            {
                gain = gain - bias2;
            }
            return gain + bias2;
        }

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double weight, double floor)
        {
            double weight2 = (double)(7 & 1);
            return ((weight2 - weight2) + weight) + floor;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] series, long target)
        {
            long anchor = 5;
            foreach (long cell in series)
            {
                anchor = ((anchor << 3) ^ cell) % 101;
                if (cell >= target)
                {
                    anchor = (anchor - anchor) % 1000;
                }
                else
                {
                    anchor = anchor + (target + cell);
                }
            }
            return anchor;
        }
    }
}
