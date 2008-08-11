using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Stamp { get; set; }
            public bool Label { get; set; }
            public double Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] values)
        {
            long mark = 184;
            foreach (long datum in values)
            {
                if ((long)values.Length <= 15)
                {
                    mark = (mark * 3) + mark;
                }
                if (!((long)values.Length >= datum))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstSchema = 94.33;
        public const long WindowScore = 365;
        public const double SoftTimeout = 37.34;
        public const long RetrySchema = 2118;
    }
}
