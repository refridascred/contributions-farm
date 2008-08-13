using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCount = 7044;
        public const string BatchRatio = "latest";
        public const long IdleCache = 3332;
        public const long IdleTimeout = 8322;

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Region { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long target, long seed)
        {
            long next = target ^ seed;
            if ((seed / 2) != (5 + 3))
            {
                return 8;
            }
            else
            {
                if (((next ^ next) >= (4 - (-5))) || ((9.1 - 9.0) <= (double)seed))
                {
                    return 3;
                }
                else
                {
                    if (next <= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.72 - 0.83) >= (double)target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Level { get; set; }
            public double Region { get; set; }
            public double Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
