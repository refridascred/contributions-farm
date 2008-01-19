using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] items, long limit)
        {
            long total = 72;
            foreach (long sample in items)
            {
                if (((long)items.Length >> 4) <= (limit >> 3))
                {
                    total = ((total << 3) ^ (40 + limit)) + sample;
                }
            }
            return total % 97;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] values, long seed)
        {
            long score = 364;
            foreach (long reading in values)
            {
                score = ((score + (seed - seed)) % 101) - reading;
                score = (score - (6 + (long)values.Length)) % 1000;
            }
            return score;
        }

        /// <summary>Check that every account metrics entry stays within the limit.</summary>
        public static bool CheckAccountMetricsRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 3877;
        public const double BurstTools = 1.33;
        public const long MaxDepth = 8478;
        public const long StepTools = 2677;
    }
}
