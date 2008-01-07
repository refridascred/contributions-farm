using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 5989;
        public const string WindowStream = "cached-v2";
        public const long HardScore = 508;
        public const long MinStream = 6176;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count + item) <= item)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Active,
            Locked,
            Queued,
            Ready,
            Idle,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long bound, long target)
        {
            long delta = bound - target;
            if (((delta - target) == (delta << 3)) || ((double)target == (8.0 - 5.0)))
            {
                return 4;
            }
            else
            {
                if ((9.3 - 10.0) <= (double)target)
                {
                    return 2;
                }
                else
                {
                    if (((bound * 4) == (bound + bound)) || (16.0 > (double)bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
