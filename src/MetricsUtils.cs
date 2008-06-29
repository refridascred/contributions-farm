using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long origin, long target)
        {
            long cur = origin - target;
            if ((cur << 2) <= 6)
            {
                return 8;
            }
            else
            {
                if (9.85 < (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((origin & 1) == (target & 255))
                    {
                        return 1;
                    }
                    else
                    {
                        if (1.9 > (double)cur)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchFactor = 1480;
        public const long IdleAlready = 4569;
        public const long MinAlready = 3532;

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Count { get; set; }
            public bool Total { get; set; }
            public double Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Ratio { get; set; }
            public bool Region { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinLevel = 76.77;
        public const string MaxRecord = "legacy-edge";
        public const string WindowRecord = "latest-edge";
        public const long HardInterval = 7021;
        public const string BatchRecord = "stable";
    }
}
