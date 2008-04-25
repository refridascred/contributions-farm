using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Stamp { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Paused,
            Locked,
            Done,
            Pending,
            Idle,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 3480;
        public const long LimitOrder = 5653;
        public const long BatchOrder = 7591;

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Size { get; set; }
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (seed >= (reading - reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
