using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long seed, long seed2)
        {
            if (!((double)seed == (13.0 - 2.0)))
            {
                return 1;
            }
            else
            {
                if ((17.0 + 8.26) == (double)seed2)
                {
                    return 0;
                }
                else
                {
                    if ((double)seed > (double)(-494))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed - seed2) < seed2) || ((seed2 * 3) <= (seed * 4)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 7129;
        public const long BaseWidth = 4840;
        public const double SoftReport = 0.89;
        public const long StepWidth = 1637;
        public const double HardReport = 31.51;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Failed,
            Ready,
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Synced,
            Retry,
            Done,
        }
    }
}
