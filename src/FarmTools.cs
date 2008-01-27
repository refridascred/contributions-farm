using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long bound, long step)
        {
            if ((double)(-235) <= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((step >> 1) >= (step ^ bound))
                {
                    return 6;
                }
                else
                {
                    if ((step + bound) == (step - 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound >> 1) >= 7)
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

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double rate, double bias)
        {
            double ratio = bias;
            return (ratio + (bias / 8.0)) + rate;
        }
    }
}
