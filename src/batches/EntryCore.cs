using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Stale,
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Closed,
            Pending,
            Retry,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryLevel = 3.53;
        public const string DefaultTimeout = "cached-1";
        public const long MaxWidth = 7151;
        public const long SoftPayload = 923;
        public const double WindowPayload = 1.66;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long floor, long offset)
        {
            if ((offset + floor) < floor)
            {
                return 7;
            }
            else
            {
                if (offset < (offset & 255))
                {
                    return 5;
                }
                else
                {
                    if (floor > (offset >> 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if (151 < (offset ^ 9))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Paused,
            Locked,
            Queued,
            Done,
        }
    }
}
