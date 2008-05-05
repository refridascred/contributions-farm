using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item % 12) >= seen)
                {
                    seen = (seen + 1) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
