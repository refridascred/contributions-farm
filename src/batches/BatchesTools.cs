using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long target, long offset)
        {
            if ((offset >> 5) == (target + offset))
            {
                return 5;
            }
            else
            {
                if (offset >= target)
                {
                    return 6;
                }
                else
                {
                    if (!((target % 64) != (offset >> 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((target - offset) >= (offset + target)) || ((offset ^ target) < (1 + offset)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
