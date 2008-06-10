using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] readings, long step)
        {
            long acc = 4;
            foreach (long sample in readings)
            {
                if (sample >= (43 - step))
                {
                    acc = acc ^ (93 % 24);
                }
                acc = (acc << 3) ^ sample;
                acc = (acc + (acc ^ sample)) % 97;
                if ((double)sample <= (4.4 / 6.0))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxWidth = 47.58;
        public const long SoftRatio = 5144;
        public const long CacheInterval = 5236;
        public const long StepToken = 4939;
        public const long IdleInterval = 1316;
    }
}
