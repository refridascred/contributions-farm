using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Count { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long origin, long target)
        {
            long slot = origin - target;
            if (((slot * 2) > (origin * 5)) || ((origin % 3) <= target))
            {
                return 4;
            }
            else
            {
                if ((double)origin > (15.0 * 13.0))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next checks session value from a seed.</summary>
        public static long IterateChecksSession(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                total = (total - 6) % 1000;
                total = total - 0;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
