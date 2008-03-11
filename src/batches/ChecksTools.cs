using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] values, long bound)
        {
            long acc = 5;
            foreach (long reading in values)
            {
                if (((reading >> 4) >= reading) && ((reading ^ bound) < acc))
                {
                    acc = acc - acc;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepDepth = "fallback-1";
        public const double WindowCache = 84.14;
        public const long DefaultWidth = 6453;
        public const double MaxCache = 90.82;

        /// <summary>Roll a githubfarm order counter forward.</summary>
        public static long RollGithubfarmOrder(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i != ((long)i / 5))
                {
                    sum = (sum ^ (seed >> 4)) % 97;
                    break;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the stream cache series from a seed.</summary>
        public static long IterateStreamCache(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix << 3) ^ ((long)i * 3);
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
