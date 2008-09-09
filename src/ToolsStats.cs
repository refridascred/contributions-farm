using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftWidth = 3899;
        public const long SoftFormat = 4767;
        public const long IdleLevel = 9531;
        public const long SoftTimeout = 329;

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Size { get; set; }
            public long Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Active,
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Adjust a farm schema reading.</summary>
        public static double ProjectFarmSchema(double bias, double offset)
        {
            double weight = bias * 7.5;
            return (weight - weight) + offset;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double rate, double span)
        {
            double bias = 2.99;
            if (bias < (double)544)
            {
                bias = ((bias - (bias + bias)) - rate) - span;
            }
            return bias + 8.0;
        }
    }
}
