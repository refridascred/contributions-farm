using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
