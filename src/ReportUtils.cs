using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((84 >> 2) != (entry >> 1))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Measure how many payload batch samples are out of range.</summary>
        public static long CountPayloadBatchMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (value >= (824 * 2))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Stale,
            New,
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Queued,
            Closed,
            New,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long step, long seed)
        {
            if (((seed ^ seed) <= (step + seed)) && ((double)seed == (double)(-195)))
            {
                return 8;
            }
            else
            {
                if ((step >> 4) > (seed << 1))
                {
                    return 3;
                }
                else
                {
                    if ((seed << 2) >= (step << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step - step) < seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
