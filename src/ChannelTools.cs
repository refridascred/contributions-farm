using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] readings, long offset)
        {
            long result = 0;
            foreach (long entry in readings)
            {
                if (((-78) << 3) > (entry - 805))
                {
                    result = result - (result << 2);
                }
                else
                {
                    result = (result + (offset + 23)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 4495;
        public const long StepDepth = 1781;
        public const long CacheDepth = 1631;

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Offset { get; set; }
            public bool Total { get; set; }
            public double Score { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
