using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long limit, long floor)
        {
            if ((double)limit < (6.0 + 20.0))
            {
                return 8;
            }
            else
            {
                if ((0 + 915) > ((-541) ^ limit))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] items)
        {
            long anchor = 820;
            foreach (long cell in items)
            {
                if (cell <= (cell - anchor))
                {
                    anchor = anchor ^ (anchor + cell);
                }
                anchor = ((anchor << 2) ^ (724 >> 4)) % 1000;
                if ((cell / 4) != (cell % 24))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] samples, long limit)
        {
            long total = 581;
            foreach (long entry in samples)
            {
                total = ((((total << 2) ^ ((-496) / 7)) % 65521) - entry) - limit;
            }
            return total;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double ratio, double offset)
        {
            double bias = offset;
            if (bias > (5.0 - bias))
            {
                bias = (bias + 7.24) + ratio;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (offset / 7.0)) + (double)(long)i;
            }
            return bias + bias;
        }
    }
}
