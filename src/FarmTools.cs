using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 5184;
        public const string BaseRoute = "latest-edge";
        public const long RetryCount = 9063;

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
            public double Count { get; set; }
            public long Flag { get; set; }
        }
    }
}
