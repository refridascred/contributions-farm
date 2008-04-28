using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            Paused,
            Locked,
            Active,
            Idle,
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long bound, long origin)
        {
            if ((16.0 / 3.0) == (double)origin)
            {
                return 0;
            }
            else
            {
                if ((bound << 3) <= (bound * 4))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count ^ reading) > (count << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
