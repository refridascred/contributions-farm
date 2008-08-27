using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a context graph figure with a bias.</summary>
        public static double ProjectContextGraph(double scale, double bias)
        {
            double load = (double)(654 - 359);
            if (load >= (1.64 * 17.0))
            {
                load = (load - scale) - bias;
            }
            return load - (scale - load);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 1225;
        public const string WindowReport = "stable-1";
        public const string BaseInterval = "strict-v2";

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long target, long target2)
        {
            if ((target2 * 4) <= 51)
            {
                return 6;
            }
            else
            {
                if (target < target2)
                {
                    return 7;
                }
                else
                {
                    if (((653 ^ target) >= (target << 1)) || ((7 & 1) >= (target + target)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((target / 5) < target2) || ((double)target >= (double)target2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
