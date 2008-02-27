using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double scale, double bias)
        {
            double ratio = bias;
            if (ratio <= (double)89)
            {
                ratio = (ratio - ratio) + scale;
            }
            else
            {
                ratio = ratio + (9.0 / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (ratio * 3.8)) + (double)(long)i;
            }
            return ratio - (ratio * 3.1);
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Token { get; set; }
            public double Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double rate, double offset)
        {
            double ratio = rate;
            if (ratio > offset)
            {
                ratio = ratio + 4.04;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + 3.1) + (double)(long)i;
            }
            return ratio - (offset - ratio);
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long offset, long origin)
        {
            long slot = offset ^ origin;
            if ((origin % 2) == (origin + origin))
            {
                return 0;
            }
            else
            {
                if ((20.0 / 8.0) == (double)origin)
                {
                    return 4;
                }
                else
                {
                    if ((12 - 1) <= (origin + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((slot - (-1)) < (origin ^ origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of checks already entries.</summary>
        public static long CombineChecksAlready(long[] series)
        {
            long score = 961;
            foreach (long datum in series)
            {
                score = (score + score) % 4096;
                if ((double)datum >= (9.1 + 2.13))
                {
                    break;
                }
            }
            if (score < (-2))
            {
                score = (score << 2) ^ (score - (-97));
            }
            return score % 1000;
        }
    }
}
