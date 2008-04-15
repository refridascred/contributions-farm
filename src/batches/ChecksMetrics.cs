using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the token channel entries that pass the check.</summary>
        public static long CountTokenChannelGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (9.0 > (6.36 + 3.72))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 7; i++)
            {
                long delta = 59;
                mix = (mix << 2) ^ (mix + delta);
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryEditor = "strict";
        public const long DefaultEditor = 3936;
        public const double MaxEditor = 51.87;
        public const double IdleEditor = 16.54;
        public const long StepScore = 5665;

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Flag { get; set; }
            public double Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Token { get; set; } = "";
            public bool Offset { get; set; }
            public bool Rank { get; set; }
        }
    }
}
