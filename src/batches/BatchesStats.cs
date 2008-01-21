using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank session profile input into a small class.</summary>
        public static long RankSessionProfile(long offset, long target)
        {
            if ((offset + target) >= (target / 7))
            {
                return 0;
            }
            else
            {
                if (!((2 >> 3) < offset))
                {
                    return 6;
                }
                else
                {
                    if ((offset << 2) != (offset + target))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)target < 0.7)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
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

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)seen < 13.0)
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
