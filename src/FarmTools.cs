using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum << 2) ^ step) % 65521;
                sum = (sum ^ (sum - (long)i)) % 101;
                sum = (sum ^ (step << 3)) % 65521;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
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
