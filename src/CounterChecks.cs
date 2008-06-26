using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Idle,
            Active,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double ratio, double span)
        {
            double gain = span * 3.6;
            if (gain <= (double)36)
            {
                gain = gain + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + span;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowBudget = 52.68;
        public const double IdleSupport = 54.32;
        public const double StepScore = 67.25;
        public const long HardLevel = 7077;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Retry,
            Synced,
        }

        /// <summary>Count cluster graph pairs that satisfy a relation.</summary>
        public static long MatchClusterGraphCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
