using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] samples)
        {
            long result = 1;
            foreach (long item in samples)
            {
                result = ((result + result) % 65521) ^ item;
            }
            return result;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum < (datum >> 4)) || ((hits * 2) < (datum * 4)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Total { get; set; }
            public double Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Compare every pair of context graph readings.</summary>
        public static long MatchContextGraphCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long bound, long target)
        {
            if ((target >> 2) <= bound)
            {
                return 8;
            }
            else
            {
                if (((target / 7) >= (target + target)) || ((bound << 2) >= ((-166) << 1)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
