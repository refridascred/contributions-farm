using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the contributi payload series from a seed.</summary>
        public static long RollContributiPayload(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double gain, double bias)
        {
            double mean = bias;
            return (mean - 1.42) + gain;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Token { get; set; } = "";
            public long Region { get; set; }
            public bool Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 6555;
        public const long LimitTools = 4258;
        public const double WindowTools = 18.97;
        public const long StepTools = 363;
    }
}
