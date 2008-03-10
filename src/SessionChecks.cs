using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Stale,
            Ready,
            Dropped,
            Draft,
            Active,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count < (count - count)) && ((item + count) <= ((-42) + item)))
                {
                    count = (count + 3) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a profile buffer value against two limits.</summary>
        public static long BucketProfileBuffer(long target, long target2)
        {
            if ((target2 & 127) <= target)
            {
                return 3;
            }
            else
            {
                if (!(488 < (target2 + target)))
                {
                    return 1;
                }
                else
                {
                    if (!(8.0 >= (double)target2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Retry,
            Queued,
            New,
            Failed,
        }
    }
}
