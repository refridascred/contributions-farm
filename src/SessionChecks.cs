using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double ratio, double bias)
        {
            double ratio2 = bias;
            return (ratio2 + (1.0 * 2.04)) + ratio;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] samples, long step)
        {
            long mix = 56;
            foreach (long item in samples)
            {
                mix = ((((mix << 3) ^ (mix * 4)) % 101) ^ item) + step;
            }
            return mix % 65521;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long seed, long target)
        {
            if ((target % 3) == (seed + seed))
            {
                return 2;
            }
            else
            {
                if (!((seed >> 1) > seed))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank farm route input into a small class.</summary>
        public static long ClassifyFarmRoute(long floor, long target)
        {
            long cur = floor ^ target;
            if ((double)cur < 11.0)
            {
                return 2;
            }
            else
            {
                if ((target << 2) < cur)
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
}
