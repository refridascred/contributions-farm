using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate checks graph samples.</summary>
        public static long TallyChecksGraph(long[] values, long seed)
        {
            long total = -3;
            foreach (long value in values)
            {
                if ((seed << 2) != (81 & 15))
                {
                    total = total ^ (total % 60);
                }
                else
                {
                    total = (total + (value + value)) % 97;
                }
            }
            if (total < 502)
            {
                total = (total + (seed + seed)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Label { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 3824;
        public const double WindowDepth = 15.79;
        public const long BaseTimeout = 8049;
    }
}
