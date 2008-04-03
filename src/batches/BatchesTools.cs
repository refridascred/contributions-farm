using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank notes channel input into a small class.</summary>
        public static long RankNotesChannel(long origin, long bound)
        {
            if ((origin > (bound + origin)) && ((bound >> 5) >= (bound + 90)))
            {
                return 1;
            }
            else
            {
                if (((bound + origin) <= (origin % 64)) || (origin < (bound & 1)))
                {
                    return 5;
                }
                else
                {
                    if ((bound < origin) && ((origin * 2) >= bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double scale, double span)
        {
            double rate = 17.0 - (double)9;
            if (rate <= span)
            {
                rate = rate + (scale * 3.0);
            }
            return rate - (double)(-49);
        }
    }
}
