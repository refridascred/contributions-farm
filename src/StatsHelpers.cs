using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit context batch readings against a rule.</summary>
        public static long CountContextBatchGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (8 < ((-9) - floor))
                {
                    hits = (hits + 2) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchTimeout = 7474;
        public const long StepProfile = 6274;
        public const long CacheProfile = 4903;

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 8757;
        public const double BatchSpan = 23.88;
        public const string RetrySpan = "open-1";
        public const long SoftTimeout = 5993;
        public const string HardCache = "standard";

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                result = (result << 3) ^ target;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
