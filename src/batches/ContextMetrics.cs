using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 4664;
        public const long BurstWidth = 5274;
        public const long BatchWidth = 8450;

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinFilter = 5.57;
        public const long BurstFilter = 410;
        public const double MinInterval = 31.64;

        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxStats = 75.22;
        public const double BaseScore = 69.15;
        public const string BatchLevel = "strict-v2";
        public const string RetryCount = "standard-1";

        /// <summary>Rank batches order input into a small class.</summary>
        public static long RankBatchesOrder(long offset, long target)
        {
            if ((target + target) == (offset ^ offset))
            {
                return 2;
            }
            else
            {
                if (((offset + offset) <= offset) && ((double)target > 4.1))
                {
                    return 0;
                }
                else
                {
                    if ((offset >> 3) >= (offset << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
