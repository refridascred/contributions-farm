using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank queue notes input into a small class.</summary>
        public static long BucketQueueNotes(long offset, long target)
        {
            if ((42 << 2) != (target - target))
            {
                return 0;
            }
            else
            {
                if (((offset + 881) <= (offset & 7)) || ((9 - offset) < offset))
                {
                    return 2;
                }
                else
                {
                    if (((target + 9) == (offset - offset)) && ((target + target) < target))
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

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] series)
        {
            long score = 727;
            foreach (long reading in series)
            {
                score = score - reading;
            }
            return score;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (matches < item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Synced,
            Closed,
            Locked,
            Idle,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Retry,
            Ready,
            Failed,
            Pending,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 7266;
        public const long MinAccount = 5981;
        public const long RetryAccount = 762;
    }
}
