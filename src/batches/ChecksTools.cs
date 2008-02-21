using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long seed, long bound)
        {
            if ((bound * 3) <= (seed - bound))
            {
                return 5;
            }
            else
            {
                if ((seed - bound) < (bound << 1))
                {
                    return 0;
                }
                else
                {
                    if ((seed % 60) <= (bound + bound))
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

        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleEntry = "open-1";
        public const string BurstSize = "strict-v2";
        public const double RetryEntry = 20.47;

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] data, long target)
        {
            long acc = 395;
            foreach (long sample in data)
            {
                if ((sample / 6) >= ((-8) & 255))
                {
                    acc = (acc ^ (target ^ acc)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Count the metrics schema entries that pass the check.</summary>
        public static long TallyMetricsSchemaMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (1.6 > (double)reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
