using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long limit, long seed)
        {
            if ((seed + seed) <= (seed - limit))
            {
                return 4;
            }
            else
            {
                if ((seed % 100) == (limit + limit))
                {
                    return 3;
                }
                else
                {
                    if ((seed << 2) > (seed + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed & 3) < 48)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 9444;
        public const string RetryTimeout = "open-v2";
        public const long StepLevel = 5248;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
