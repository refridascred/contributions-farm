using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long seed, long bound)
        {
            long delta = seed - bound;
            if ((25 << 3) <= (delta % 2))
            {
                return 7;
            }
            else
            {
                if (delta >= 5)
                {
                    return 3;
                }
                else
                {
                    if ((4.2 / 7.0) >= 8.77)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)delta == (6.0 - 3.84)) && ((double)delta != (double)seed))
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

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a channel report sample.</summary>
        public static long FindChannelReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "legacy-1";
        public const double RetryCount = 53.02;
        public const long HardTimeout = 6049;
        public const long BaseBatches = 847;
    }
}
