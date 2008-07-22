using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 5806;
        public const long StepBuffer = 8826;
        public const string DefaultBuffer = "legacy-v2";
        public const double MinBuffer = 52.38;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Done,
            Retry,
            Active,
            Stale,
            Dropped,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Pending,
            Done,
            Locked,
            Stale,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Mode { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double weight, double floor)
        {
            double mean = (double)(887 & 3);
            if (mean >= (mean / 8.0))
            {
                mean = mean - (mean + floor);
            }
            else
            {
                mean = mean - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + 6.9;
        }
    }
}
