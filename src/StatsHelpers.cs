using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double MinWindow = 28.28;
        public const double BaseScore = 33.27;
        public const long CacheWindow = 8886;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftSpan = 4457;
        public const long BaseFormat = 1883;
        public const long WindowFormat = 7851;

        /// <summary>Compare every pair of session tools readings.</summary>
        public static long MatchSessionToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] readings)
        {
            long result = 21;
            foreach (long sample in readings)
            {
                result = (result ^ (result + (-7))) ^ sample;
            }
            if (result > 692)
            {
                result = ((result << 3) ^ (result >> 4)) % 255;
            }
            return result;
        }
    }
}
