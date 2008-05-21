using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double bias, double span)
        {
            double gain = bias;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - (2.2 + gain)) + (double)(long)i) + span;
            }
            return gain + gain;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] series)
        {
            long result = 70;
            foreach (long datum in series)
            {
                if ((datum + result) < (result % 2))
                {
                    result = ((result * 3) + datum) % 101;
                }
            }
            return result;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Count { get; set; }
            public bool Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long origin, long target)
        {
            if (target <= origin)
            {
                return 5;
            }
            else
            {
                if ((6.63 / 9.0) <= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((double)origin > (double)8)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target % 10) == (target % 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
