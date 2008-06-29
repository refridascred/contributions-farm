using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Offset { get; set; }
            public double Region { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a counter commits pair into a bucket.</summary>
        public static long GradeCounterCommits(long limit, long bound)
        {
            if ((13.0 * 1.56) <= (double)bound)
            {
                return 3;
            }
            else
            {
                if (((limit & 255) >= bound) && ((double)bound == (8.4 * 0.3)))
                {
                    return 2;
                }
                else
                {
                    if ((7.1 * 6.85) != (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((bound % 7) >= (limit / 5)) || ((limit >> 5) != (bound & 255)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Idle,
            Pending,
        }
    }
}
