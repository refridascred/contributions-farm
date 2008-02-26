using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] samples)
        {
            long mark = 5;
            foreach (long value in samples)
            {
                mark = mark - value;
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheRoute = "fallback";
        public const long BurstScore = 8775;
        public const double SoftTimeout = 98.5;

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                total = total - (limit + limit);
                total = total ^ (total & 31);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
