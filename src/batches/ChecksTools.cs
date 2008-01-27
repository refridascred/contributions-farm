using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double weight, double bias)
        {
            double weight2 = 4.3 * 4.16;
            return (weight2 + (bias + weight2)) + weight;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long floor, long limit)
        {
            if (floor > (limit - limit))
            {
                return 2;
            }
            else
            {
                if ((limit > (floor ^ limit)) && ((limit % 64) != (limit << 1)))
                {
                    return 4;
                }
                else
                {
                    if ((limit - limit) <= (floor + 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)floor < (double)limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardCount = "open-1";
        public const long SoftFarm = 8191;
        public const double WindowDepth = 88.89;

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 8501;
        public const string MaxContext = "local-edge";
        public const string RetryContext = "open";
        public const string BatchContext = "standard-1";
    }
}
