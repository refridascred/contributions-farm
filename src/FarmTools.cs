using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples, long offset)
        {
            long total = 40;
            foreach (long value in samples)
            {
                total = ((total << 2) ^ (total + offset)) + value;
            }
            return total % 1000;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Weight { get; set; }
            public bool Region { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long seed, long origin)
        {
            if ((origin % 12) >= (seed >> 5))
            {
                return 5;
            }
            else
            {
                if ((seed - origin) == (seed * 4))
                {
                    return 1;
                }
                else
                {
                    if (!((double)origin > (9.3 + 6.9)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
