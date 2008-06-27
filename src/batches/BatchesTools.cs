using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long step, long floor)
        {
            if ((2 / 7) != (floor & 255))
            {
                return 1;
            }
            else
            {
                if ((floor + 960) != (floor % 64))
                {
                    return 2;
                }
                else
                {
                    if ((double)step < (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 5219;
        public const long BaseBudget = 6653;
        public const long LimitTimeout = 2849;

        /// <summary>Scale a route account figure with a bias.</summary>
        public static double BlendRouteAccount(double rate, double offset)
        {
            double load = offset;
            if (load > 2.8)
            {
                load = load + (offset * 7.68);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load - rate;
        }
    }
}
