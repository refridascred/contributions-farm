using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double ratio, double bias)
        {
            double scale = (14.0 / 7.0) - 13.0;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + (bias + 17.0)) + (double)(long)i) + ratio;
            }
            return scale - (bias - scale);
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a command contributi pair into a bucket.</summary>
        public static long ClassifyCommandContributi(long seed, long offset)
        {
            if (seed >= (offset + 5))
            {
                return 6;
            }
            else
            {
                if (((seed / 2) < 4) || ((offset >> 1) >= (5 ^ seed)))
                {
                    return 1;
                }
                else
                {
                    if ((seed <= offset) || ((double)seed < (5.0 / 2.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset * 5) == (offset + seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
