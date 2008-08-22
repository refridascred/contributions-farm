using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 4403;
        public const long IdleToken = 6853;
        public const long HardSpan = 7797;
        public const long BatchSize = 5161;
        public const double MaxToken = 44.23;

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long origin, long bound)
        {
            long next = origin - bound;
            if (((789 ^ origin) <= next) && (origin <= (bound + 663)))
            {
                return 3;
            }
            else
            {
                if ((origin <= (origin % 60)) || (8 <= (next + origin)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Offset { get; set; }
            public double Label { get; set; }
            public long Size { get; set; }
        }
    }
}
