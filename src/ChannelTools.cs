using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!(cell < (859 + cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitWidth = 57.2;
        public const long MinRatio = 3087;
        public const long StepWidth = 4033;
        public const string WindowBatch = "local-edge";

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
