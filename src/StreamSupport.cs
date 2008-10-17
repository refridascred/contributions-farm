using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 7367;
        public const double LimitInterval = 39.67;
        public const string SoftContext = "alpha";
        public const long LimitContext = 8979;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count + count) > (target >> 4)) || ((count * 5) <= (item + target)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultMetric = 86.56;
        public const double SoftMetric = 82.36;
        public const long HardDepth = 5299;
    }
}
