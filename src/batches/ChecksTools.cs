using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 1642;
        public const long SoftInterval = 5138;
        public const long BaseInterval = 1349;
        public const long SoftRecord = 7966;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 4968;
        public const long RetrySpan = 1151;
        public const long BurstFilter = 7568;
        public const long DefaultBudget = 9449;
        public const long DefaultScore = 1446;
    }
}
