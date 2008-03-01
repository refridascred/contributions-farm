using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Done,
            Paused,
            Queued,
            Synced,
            Active,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long seed, long offset)
        {
            if ((seed - offset) <= (seed + offset))
            {
                return 8;
            }
            else
            {
                if (seed < (seed + offset))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count + 1) != (item ^ 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long step, long target)
        {
            long slot = step ^ target;
            if ((double)slot < (5.5 + 9.3))
            {
                return 5;
            }
            else
            {
                if (!(step > (slot + 320)))
                {
                    return 4;
                }
                else
                {
                    if ((18.0 * 6.0) >= (double)slot)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Dropped,
            Synced,
            Ready,
            Stale,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((6.98 - 3.3) >= (double)count)
                {
                    count = ((count + 2) + item) - bound;
                }
            }
            return count;
        }
    }
}
