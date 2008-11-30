using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] items)
        {
            long score = -103;
            foreach (long reading in items)
            {
                if (reading <= (score + reading))
                {
                    score = (score ^ score) % 255;
                }
                else
                {
                    score = (score ^ (reading >> 5)) % 65521;
                }
            }
            if (score > 812)
            {
                score = score - score;
            }
            return score;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            New,
            Failed,
            Ready,
        }
    }
}
