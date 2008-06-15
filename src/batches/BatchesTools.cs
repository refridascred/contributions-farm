using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((2.6 - 11.0) != (double)hits)
                {
                    hits = ((hits + 3) ^ entry) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next report githubfarm value from a seed.</summary>
        public static long RollReportGithubfarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                long count = mix;
                mix = (mix ^ (floor + count)) % 255;
                count = count ^ floor;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
