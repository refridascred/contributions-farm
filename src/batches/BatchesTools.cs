using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long target, long step)
        {
            if (((step * 4) != (target - target)) || ((double)target > (6.4 + 2.4)))
            {
                return 8;
            }
            else
            {
                if ((53 + step) < (-98))
                {
                    return 5;
                }
                else
                {
                    if ((1.4 / 5.0) == (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((origin ^ seen) < (seen ^ 73))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public double Owner { get; set; }
        }
    }
}
