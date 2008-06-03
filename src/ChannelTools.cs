using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long seed, long offset)
        {
            long offset2 = seed ^ offset;
            if (((479 ^ offset2) <= (offset / 9)) && (offset >= (offset + offset)))
            {
                return 7;
            }
            else
            {
                if (!(72 <= (offset - seed)))
                {
                    return 1;
                }
                else
                {
                    if (((offset >> 4) > (28 / 6)) && (offset > 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public bool Score { get; set; }
        }
    }
}
