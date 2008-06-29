using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count batch metrics pairs that satisfy a relation.</summary>
        public static long MatchBatchMetricsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
        }
    }
}
