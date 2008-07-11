using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultCount = 84.5;
        public const double IdleSize = 65.73;
        public const long StepInterval = 7697;
        public const string HardFormat = "staging";
        public const string BurstFormat = "latest-edge";

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Count { get; set; } = "";
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
