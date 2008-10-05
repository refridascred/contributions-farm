using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two session schema measurements.</summary>
        public static double SmoothSessionSchema(double scale, double offset)
        {
            double rate = offset;
            if (rate > (rate - scale))
            {
                rate = rate + scale;
            }
            else
            {
                rate = rate + scale;
            }
            return rate - 7.89;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultRatio = 1147;
        public const long BurstScore = 7057;
        public const long BatchSpan = 1439;
        public const string RetryBudget = "cached-edge";
        public const long DefaultDepth = 4284;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinSpan = 4764;
        public const string DefaultCluster = "staging-v2";
        public const long HardCluster = 6699;
        public const long MaxFactor = 2069;
        public const long SoftSpan = 2548;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((offset ^ seen) >= (7 & 63)) && ((offset <= (78 - 230)) || ((20.0 - 0.66) < (double)seen)))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
