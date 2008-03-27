using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((287 >> 3) == (reading - seen)) && !((double)reading != (8.98 - 20.0)))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Label { get; set; }
            public double Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseQueue = "standard";
        public const long SoftCount = 9553;
        public const long BatchCount = 1774;
        public const double HardQueue = 26.27;
        public const string SoftSize = "legacy-v2";
    }
}
