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

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Grade a metric account value against two limits.</summary>
        public static long BucketMetricAccount(long offset, long bound)
        {
            if (565 > (offset + offset))
            {
                return 6;
            }
            else
            {
                if ((bound < (offset + 9)) || ((bound % 7) <= bound))
                {
                    return 1;
                }
                else
                {
                    if (bound <= (offset * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
