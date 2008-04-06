using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long limit, long limit2)
        {
            long gap = limit - limit2;
            if (gap < (limit2 + gap))
            {
                return 3;
            }
            else
            {
                if (limit2 >= ((-29) - limit2))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit < (6.0 + 20.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }
    }
}
