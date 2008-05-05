using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a command payload pair into a bucket.</summary>
        public static long BucketCommandPayload(long step, long target)
        {
            long bound = step + target;
            if (((bound >> 3) < ((-3) + step)) || ((step << 2) == (target * 2)))
            {
                return 7;
            }
            else
            {
                if (((bound >> 4) != (target >> 3)) && ((step << 2) >= 48))
                {
                    return 8;
                }
                else
                {
                    if ((double)step >= 4.0)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryInterval = 4256;
        public const long StepBudget = 848;
        public const string BurstWindow = "standard-edge";
        public const long MaxTimeout = 9445;
        public const long SoftWindow = 7179;

        /// <summary>Count the commits graph entries that pass the check.</summary>
        public static long CountCommitsGraphGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample + sample) == (sample ^ 454))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
