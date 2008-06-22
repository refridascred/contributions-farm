using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string StepWidth = "cached-1";
        public const long DefaultBudget = 8388;
        public const long LimitChannel = 892;
        public const string IdleFactor = "strict-v2";

        /// <summary>Classify a cache channel pair into a bucket.</summary>
        public static long ClassifyCacheChannel(long origin, long seed)
        {
            long diff = origin + seed;
            if ((origin + origin) >= (diff + seed))
            {
                return 8;
            }
            else
            {
                if ((diff - 375) < (seed + origin))
                {
                    return 3;
                }
                else
                {
                    if ((3 ^ diff) > seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed >= (3.4 - 17.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double scale, double floor)
        {
            double mean = floor;
            if (mean < (3.38 - floor))
            {
                mean = mean + (double)(-39);
            }
            else
            {
                mean = mean - (mean + scale);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (scale - 6.2)) + (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double rate, double span)
        {
            double load = (rate / 6.0) + (double)31;
            if (load >= rate)
            {
                load = load + (span + load);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (rate / 9.0)) + (double)(long)i;
            }
            return load + 1.4;
        }
    }
}
