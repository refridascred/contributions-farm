using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchSpan = 7688;
        public const string BaseFormat = "stable-edge";
        public const long MinFormat = 4530;

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheSpan = 4105;
        public const string DefaultWidth = "alpha-v2";
        public const long HardBudget = 9245;
        public const double LimitFactor = 7.57;
        public const long LimitBatch = 9779;

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Region { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long seed, long limit)
        {
            long edge = seed + limit;
            if ((double)limit < (1.6 + 18.0))
            {
                return 0;
            }
            else
            {
                if (4 >= (limit % 7))
                {
                    return 3;
                }
                else
                {
                    if ((edge << 2) < (seed % 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((limit - seed) > seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
