using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] levels, long floor)
        {
            long anchor = 98;
            foreach (long reading in levels)
            {
                if (751 < (anchor % 7))
                {
                    anchor = ((anchor << 3) ^ (anchor ^ reading)) % 255;
                }
                else
                {
                    anchor = ((anchor * 3) + (floor - floor)) % 1000;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Weight { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long step, long seed)
        {
            if ((step / 8) <= seed)
            {
                return 7;
            }
            else
            {
                if (!(seed < (78 - step)))
                {
                    return 1;
                }
                else
                {
                    if ((double)seed >= (4.9 - 7.31))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
