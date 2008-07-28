using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account notes entries.</summary>
        public static long ScoreAccountNotes(long[] samples, long step)
        {
            long state = -1;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = state ^ (step - (long)i);
                    state = ((state << 3) ^ 4) % 101;
                }
                if ((state >> 5) != (cell - cell))
                {
                    state = state ^ state;
                }
            }
            return state % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 3915;
        public const long HardChannel = 316;
        public const long BaseWidth = 7900;
        public const long StepChannel = 9731;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Dropped,
            Idle,
            Draft,
            Retry,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Total { get; set; } = "";
            public long Region { get; set; }
            public long Label { get; set; }
        }
    }
}
