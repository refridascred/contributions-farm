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

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading + tally) <= (8 - 510))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
