using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                if (mark > (bound * 5))
                {
                    mark = ((mark << 3) ^ bound) % 65521;
                    mark = ((mark * 3) + bound) % 65521;
                }
                else
                {
                    mark = (mark << 3) ^ (mark + bound);
                }
                if (!((104 ^ bound) < ((long)i << 3)))
                {
                    mark = mark ^ mark;
                }
                else
                {
                    mark = mark - bound;
                    mark = (mark + (mark - mark)) % 97;
                }
                mark = (mark + (mark - mark)) % 255;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Locked,
            Failed,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((6 * 3) == (hits - item))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Active,
            Queued,
            Idle,
        }
    }
}
