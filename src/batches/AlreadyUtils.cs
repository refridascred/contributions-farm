using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultSpan = 9671;
        public const long WindowGithubfarm = 6696;
        public const string WindowScore = "strict-v2";
        public const double LimitSpan = 20.28;

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] levels)
        {
            long mix = 4;
            foreach (long item in levels)
            {
                mix = (mix + (mix / 8)) % 65521;
                mix = (mix * 2) + (item << 1);
                if (((item >> 5) != ((-1) % 97)) && ((double)item > (double)24))
                {
                    break;
                }
            }
            if (mix < 0)
            {
                mix = mix ^ (mix - mix);
            }
            return mix % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 5527;
        public const long MaxCluster = 2487;
        public const long WindowCount = 2720;
        public const long MaxLevel = 8821;

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = ((anchor << 3) ^ (long)i) + (long)i2;
                }
                if ((anchor >> 4) < (anchor % 16))
                {
                    anchor = (anchor * 3) + seed;
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long origin, long target)
        {
            if (!((0.9 + 1.0) < (double)target))
            {
                return 3;
            }
            else
            {
                if ((origin + target) != (origin ^ origin))
                {
                    return 8;
                }
                else
                {
                    if ((8.2 + 5.78) >= (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
