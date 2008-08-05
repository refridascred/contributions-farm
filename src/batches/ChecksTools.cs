using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many metrics editor samples are out of range.</summary>
        public static long TallyMetricsEditorHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((hits + hits) != (hits << 2)) || ((double)hits < (17.0 + 0.77)))
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }

        /// <summary>Combine window channel values into a single score.</summary>
        public static long FoldWindowChannel(long[] items, long seed)
        {
            long result = 4;
            foreach (long cell in items)
            {
                long bound = seed - seed;
                if (((-7) * 2) <= (bound + cell))
                {
                    bound = ((bound << 2) ^ (8 % 60)) % 255;
                }
                if (((long)items.Length + cell) < (seed - 7))
                {
                    result = (result ^ ((long)items.Length % 16)) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Flag { get; set; }
            public double Count { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
        }
    }
}
