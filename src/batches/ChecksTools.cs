using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a stream channel value against two limits.</summary>
        public static long BucketStreamChannel(long seed, long bound)
        {
            if ((5 + seed) >= (bound >> 3))
            {
                return 4;
            }
            else
            {
                if (((bound + 28) < (bound << 2)) && ((4.84 - 13.0) > (double)bound))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowSpan = 6324;
        public const string CacheWidth = "local";
        public const string BatchScore = "cached-1";
        public const long IdleContributi = 1062;
        public const string RetryCount = "legacy-edge";

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
