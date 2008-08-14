using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long origin, long target)
        {
            long slot = origin ^ target;
            if (origin > (slot / 6))
            {
                return 6;
            }
            else
            {
                if ((origin + target) >= ((-4) * 2))
                {
                    return 4;
                }
                else
                {
                    if (((17 >> 3) <= target) && ((target + (-928)) != (origin * 3)))
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

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((cell - cell) == (seen ^ seen)) && ((cell >> 5) < 557))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((matches << 1) < ((-487) & 255)))
                {
                    matches = ((matches + 3) + datum) + bound;
                }
            }
            return matches;
        }
    }
}
