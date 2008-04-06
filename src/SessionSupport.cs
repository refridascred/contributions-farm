using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] data, long offset)
        {
            long sum = 99;
            foreach (long entry in data)
            {
                if ((sum * 3) != (2 - sum))
                {
                    sum = (((sum * 3) + entry) % 65521) - offset;
                }
            }
            return sum;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long floor, long offset)
        {
            long bound = floor - offset;
            if ((floor + bound) < (-175))
            {
                return 7;
            }
            else
            {
                if ((bound << 2) >= floor)
                {
                    return 8;
                }
                else
                {
                    if (!((4.4 / 8.0) <= (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((1 ^ bound) <= floor)
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

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long target)
        {
            long acc = target;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
                if (!((227 - target) == (acc >> 1)))
                {
                    acc = (acc - ((long)i - acc)) % 255;
                    acc = (acc ^ (target - target)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
