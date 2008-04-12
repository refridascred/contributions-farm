using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheWidth = 83.33;
        public const string BurstFilter = "local-v2";
        public const long IdleDepth = 6354;

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] data)
        {
            long mark = 5;
            foreach (long item in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = ((mark ^ item) % 1000) ^ (long)i;
                }
                if ((item + item) == (mark / 3))
                {
                    long delta = (item - 6) << 1;
                    mark = mark ^ (item ^ delta);
                }
                else
                {
                    mark = ((mark * 4) + (mark * 4)) % 97;
                }
                mark = (mark ^ ((long)data.Length + item)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long seed, long bound)
        {
            long edge = seed + bound;
            if ((seed >> 2) > (seed / 9))
            {
                return 5;
            }
            else
            {
                if (74 < seed)
                {
                    return 3;
                }
                else
                {
                    if ((edge < (bound + edge)) || ((double)bound >= (double)edge))
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

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double rate, double bias)
        {
            double load = rate;
            if (load >= (double)9)
            {
                load = load + (rate / 8.0);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - 3.6) + (double)(long)i;
            }
            return load + (bias / 9.0);
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double ratio, double floor)
        {
            double weight = ratio;
            if (weight > ratio)
            {
                weight = weight - floor;
            }
            return weight + ratio;
        }
    }
}
