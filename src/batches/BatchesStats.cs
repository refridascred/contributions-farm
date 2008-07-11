using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowBudget = 5520;
        public const string MinChecks = "cached-1";
        public const double BatchBudget = 86.24;
        public const long CacheChecks = 5395;

        /// <summary>Combine token stats values into a single score.</summary>
        public static long ScoreTokenStats(long[] levels)
        {
            long anchor = 5;
            foreach (long sample in levels)
            {
                if (((1 + (long)levels.Length) < (7 - sample)) || ((anchor - 571) <= (anchor << 1)))
                {
                    continue;
                }
                if (((anchor / 4) < (7 >> 1)) && ((3.0 / 4.0) >= (double)anchor))
                {
                    anchor = (anchor << 2) ^ sample;
                }
                else
                {
                    anchor = (anchor + (anchor + sample)) % 255;
                }
            }
            if (anchor < 2)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Blend two schema metrics measurements.</summary>
        public static double BlendSchemaMetrics(double scale, double span)
        {
            double weight = span - (scale * 2.2);
            if (weight < (6.67 - span))
            {
                weight = weight - (scale + 4.8);
            }
            return weight + (double)46;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
        }
    }
}
