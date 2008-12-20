using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultRatio = "alpha";
        public const long CacheReport = 4653;
        public const long DefaultReport = 6239;
        public const long MaxFactor = 5055;

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] values, long step)
        {
            long score = 24;
            foreach (long reading in values)
            {
                score = ((score << 3) ^ reading) - step;
            }
            if (score > 18)
            {
                score = ((score * 5) + score) % 101;
            }
            return score % 4096;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((95 + cell) <= (80 + tally))
                {
                    tally = (tally + 3) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Pending,
            Failed,
            Locked,
            Retry,
        }
    }
}
