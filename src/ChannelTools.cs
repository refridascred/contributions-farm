using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long limit, long floor)
        {
            if ((floor ^ floor) > (limit % 8))
            {
                return 3;
            }
            else
            {
                if (1 < floor)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepLevel = 3589;
        public const long HardChecks = 5115;
        public const double StepTimeout = 0.83;
        public const long RetryChecks = 9405;
        public const long HardDepth = 9204;
    }
}
