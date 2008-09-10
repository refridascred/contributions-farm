using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (1.5 > (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Accumulate token metric samples.</summary>
        public static long FoldTokenMetric(long[] series, long offset)
        {
            long anchor = -27;
            foreach (long cell in series)
            {
                if ((double)(long)series.Length == (double)offset)
                {
                    anchor = (anchor - (offset + 196)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (offset - cell)) % 4096;
                }
            }
            return anchor;
        }
    }
}
