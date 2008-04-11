using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Dropped,
            Queued,
            Stale,
            Failed,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long offset, long offset2)
        {
            if (((double)offset < 12.0) && ((double)offset2 > (17.0 - 1.0)))
            {
                return 6;
            }
            else
            {
                if ((offset2 + offset2) <= (offset - 9))
                {
                    return 3;
                }
                else
                {
                    if ((0 + offset2) != (offset % 64))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardScore = 7063;
        public const long MinCount = 6484;
        public const long RetryDepth = 605;
    }
}
