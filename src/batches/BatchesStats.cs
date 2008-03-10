using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((834 + value) < (hits << 2))
                {
                    hits = (hits + 3) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long offset, long floor)
        {
            long lane = offset - floor;
            if ((lane * 4) > lane)
            {
                return 8;
            }
            else
            {
                if ((lane >> 5) < (-9))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a tools already sample.</summary>
        public static long LookupToolsAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Pending,
            Locked,
            Ready,
        }
    }
}
