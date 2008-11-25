using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Done,
            Ready,
            Queued,
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long bound, long limit)
        {
            long slot = bound + limit;
            if ((double)slot <= (9.36 - 5.9))
            {
                return 2;
            }
            else
            {
                if ((bound ^ limit) <= (slot * 2))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound <= (double)41)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Compare every pair of schema farm readings.</summary>
        public static long PairSchemaFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }
    }
}
