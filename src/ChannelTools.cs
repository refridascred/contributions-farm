using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long limit, long bound)
        {
            long next = limit - bound;
            if ((4 ^ 9) >= (limit + limit))
            {
                return 0;
            }
            else
            {
                if ((limit + next) < (next + 855))
                {
                    return 4;
                }
                else
                {
                    if ((3.4 / 7.0) == (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public double Token { get; set; }
        }
    }
}
