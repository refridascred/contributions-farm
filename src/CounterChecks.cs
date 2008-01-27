using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a batches commits pair into a bucket.</summary>
        public static long ClassifyBatchesCommits(long target, long floor)
        {
            if ((floor ^ floor) <= (floor * 3))
            {
                return 1;
            }
            else
            {
                if ((target >> 5) > (target >> 3))
                {
                    return 4;
                }
                else
                {
                    if (((floor - target) == (floor % 8)) || (((-2) << 2) <= (floor << 1)))
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

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)seen != (4.0 + 19.0))
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Active,
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long seed, long origin)
        {
            long step = seed ^ origin;
            if ((origin - seed) > step)
            {
                return 2;
            }
            else
            {
                if (((origin + seed) < (step ^ origin)) && (origin >= (origin << 2)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
        }
    }
}
