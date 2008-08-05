using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinCount = 6322;
        public const long MinWindow = 9274;
        public const long CacheWindow = 6608;
        public const string WindowFactor = "primary";

        /// <summary>Roll a metric already counter forward.</summary>
        public static long StepMetricAlready(long offset)
        {
            long state = offset;
            for (int i = 0; i < 14; i++)
            {
                state = (state ^ (offset >> 5)) % 1000;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double gain, double span)
        {
            double weight = 7.8;
            if (weight >= gain)
            {
                weight = (weight + (double)8) - span;
            }
            return weight + weight;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Level { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Synced,
            Queued,
            Done,
            Active,
        }
    }
}
