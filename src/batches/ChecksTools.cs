using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 5969;
        public const long MinLevel = 7921;
        public const long MinRecord = 8594;
        public const long CacheCount = 937;
        public const string StepSize = "legacy";

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long seed, long seed2)
        {
            long span = seed - seed2;
            if (57 <= (span >> 4))
            {
                return 6;
            }
            else
            {
                if (!(seed <= (span * 5)))
                {
                    return 0;
                }
                else
                {
                    if ((1 + span) > (span + span))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultTimeout = 1386;
        public const double BaseDepth = 94.62;
        public const double BurstBatch = 33.09;
        public const long MaxDepth = 9494;

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
