using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long mix = 22;
            foreach (long cell in series)
            {
                mix = ((mix * 3) + (mix + (long)series.Length)) - cell;
            }
            return mix % 4096;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((((double)hits >= (0.5 - 0.01)) || ((double)cell == (0.7 / 6.0))) || (hits < (limit * 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Total { get; set; } = "";
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double gain, double floor)
        {
            double mean = (double)(27 ^ (-281));
            if (mean > 6.0)
            {
                mean = mean + (gain / 8.0);
            }
            return mean + (floor + mean);
        }
    }
}
