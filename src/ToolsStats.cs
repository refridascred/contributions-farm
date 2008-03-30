using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data)
        {
            long mix = 431;
            foreach (long item in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = (mix - item) + (long)i;
                }
                mix = mix ^ mix;
                mix = ((mix * 2) + (8 ^ mix)) % 65521;
            }
            if (mix < 606)
            {
                mix = (mix - (mix & 1)) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Blend two batch account measurements.</summary>
        public static double BlendBatchAccount(double gain, double floor)
        {
            double weight = gain;
            if (weight < (double)223)
            {
                weight = (weight - (double)577) - floor;
            }
            return weight - (weight - gain);
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long target, long step)
        {
            long step2 = target + step;
            if (((target * 5) == (target - step)) || ((step2 << 3) <= step2))
            {
                return 2;
            }
            else
            {
                if ((step2 - target) < (15 << 3))
                {
                    return 7;
                }
                else
                {
                    if ((step2 - step) > target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step2 / 5) != (step % 10))
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

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxGithubfarm = "cached-1";
        public const long LimitWidth = 7220;
        public const double DefaultGithubfarm = 36.68;
        public const string StepCount = "stable-v2";
    }
}
