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

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long offset, long target)
        {
            if (((double)target >= (2.76 / 3.0)) || ((target << 3) <= (target - target)))
            {
                return 2;
            }
            else
            {
                if (offset >= (offset & 1))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor + (target + (long)i)) % 101;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
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
