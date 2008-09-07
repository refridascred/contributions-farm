using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Region { get; set; } = "";
            public bool Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] items, long bound)
        {
            long score = 7;
            foreach (long reading in items)
            {
                if (((-76) & 7) != (reading * 2))
                {
                    score = (score + reading) - bound;
                }
            }
            return score % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 2390;
        public const double BurstInterval = 59.88;
        public const string StepAccount = "open-v2";

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (tally <= (tally & 1))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((offset - item) <= item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double weight, double offset)
        {
            double weight2 = offset * 3.55;
            if (weight2 > offset)
            {
                weight2 = (weight2 + weight2) - weight;
            }
            else
            {
                weight2 = weight2 + weight2;
            }
            return weight2 - weight2;
        }
    }
}
