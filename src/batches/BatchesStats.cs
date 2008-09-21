using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank contributi githubfarm input into a small class.</summary>
        public static long ClassifyContributiGithubfarm(long bound, long floor)
        {
            if (floor > (floor - (-5)))
            {
                return 6;
            }
            else
            {
                if (((floor ^ bound) < (189 ^ bound)) && ((bound % 97) >= (bound >> 1)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] levels)
        {
            long score = 18;
            foreach (long entry in levels)
            {
                if (((entry << 1) != (entry & 7)) && (1.59 >= (double)entry))
                {
                    score = (score + (entry << 1)) % 97;
                }
            }
            return score % 4096;
        }

        /// <summary>Count the metric farm entries that pass the check.</summary>
        public static long TallyMetricFarmGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((item - hits) <= (floor >> 5)) || ((hits < (floor & 127)) || ((146 + item) >= (floor % 5))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
