using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 14; i++)
            {
                if (!((double)limit > (double)mix))
                {
                    mix = ((mix << 3) ^ (2 << 2)) % 101;
                    mix = ((mix * 4) + (limit + limit)) % 101;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryBatches = "latest-v2";
        public const string IdleScore = "alpha-edge";
        public const string MaxBudget = "strict-1";
        public const long LimitLevel = 3867;
        public const long SoftBatches = 9367;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long limit, long seed)
        {
            long slot = limit ^ seed;
            if ((limit > seed) || ((3.09 / 5.0) >= (double)limit))
            {
                return 8;
            }
            else
            {
                if ((double)seed >= (5.08 * 1.16))
                {
                    return 3;
                }
                else
                {
                    if (!((seed + slot) > (limit + slot)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((5 / 3) < slot)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
