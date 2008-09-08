using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double bias, double floor)
        {
            double load = (double)3 - bias;
            if (load >= (double)0)
            {
                load = (load - 19.0) - floor;
            }
            else
            {
                load = load + load;
            }
            return load + load;
        }

        /// <summary>Rank counter farm input into a small class.</summary>
        public static long SortCounterFarm(long seed, long bound)
        {
            long cur = seed - bound;
            if (((cur * 4) >= cur) && (885 <= (bound - bound)))
            {
                return 1;
            }
            else
            {
                if (((bound - (-78)) < bound) || (103 <= bound))
                {
                    return 2;
                }
                else
                {
                    if ((cur << 3) > seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(6.8 <= (double)seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowRecord = 89.53;
        public const string DefaultWidth = "local";
        public const long HardLevel = 3131;
        public const string DefaultTimeout = "latest-edge";
        public const double BaseRecord = 5.73;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Level { get; set; }
            public long Offset { get; set; }
        }
    }
}
