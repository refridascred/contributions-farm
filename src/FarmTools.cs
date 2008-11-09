using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a support cluster pair into a bucket.</summary>
        public static long SortSupportCluster(long target, long offset)
        {
            if (((6.54 - 6.0) <= (double)offset) || ((target + offset) >= target))
            {
                return 4;
            }
            else
            {
                if ((9.0 / 3.0) > (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((offset + target) > target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target << 3) < target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 > (gain - 2.0))
            {
                gain2 = gain2 + (double)211;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 - gain2) + (double)(long)i;
            }
            return gain2 + (gain / 3.0);
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Region { get; set; }
            public bool Weight { get; set; }
            public long Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
