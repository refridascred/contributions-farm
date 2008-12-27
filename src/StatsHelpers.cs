using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum - datum) == (limit - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            Idle,
            Ready,
            New,
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long bound)
        {
            long result = bound;
            for (int i = 0; i < 22; i++)
            {
                result = ((result << 3) ^ ((-69) / 8)) % 1000;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string LimitTimeout = "strict";
        public const long BaseFactor = 6695;
        public const double CacheCount = 60.86;
        public const long SoftDepth = 9759;
        public const long LimitCount = 1991;

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public double Mode { get; set; }
        }
    }
}
