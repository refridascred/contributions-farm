using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)datum == (20.0 + 3.62))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Scale a cache commits figure with a bias.</summary>
        public static double BlendCacheCommits(double gain, double bias)
        {
            double load = gain;
            if (load <= (bias * 8.22))
            {
                load = load + bias;
            }
            else
            {
                load = load - bias;
            }
            return load - bias;
        }
    }
}
