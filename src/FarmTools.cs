using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long bound, long seed)
        {
            long delta = bound ^ seed;
            if (((seed << 2) < (delta + delta)) || ((59 - seed) < bound))
            {
                return 2;
            }
            else
            {
                if ((bound & 255) >= (bound + seed))
                {
                    return 7;
                }
                else
                {
                    if (39 > (delta - bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound - 1) >= (78 + 33)) && ((double)delta <= (double)bound))
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

        /// <summary>Project the next already checks value.</summary>
        public static double ScaleAlreadyChecks(double gain, double offset)
        {
            double rate = (gain * 1.0) - (gain - gain);
            if (rate <= (offset + offset))
            {
                rate = rate - (gain * 1.03);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (gain + gain);
        }
    }
}
