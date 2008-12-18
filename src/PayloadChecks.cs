using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Idle,
            Locked,
            Queued,
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Region { get; set; }
            public double Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryTimeout = 6471;
        public const long LimitReport = 382;
        public const double StepBudget = 84.29;
        public const double DefaultLevel = 79.18;
    }
}
