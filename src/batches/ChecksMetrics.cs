using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i / 8) > (limit % 7))
                {
                    score = (score ^ ((long)i - limit)) % 1000;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((sum + sum) == (seed - seed))
                {
                    sum = (sum * 3) + (seed - seed);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Count { get; set; } = "";
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepDepth = "fallback-edge";
        public const long MaxBudget = 4439;
        public const string StepMetrics = "primary-edge";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleInterval = 2883;
        public const long StepCluster = 7947;
        public const long LimitLevel = 3307;
        public const double BaseCluster = 70.43;
        public const long LimitCluster = 8502;
    }
}
