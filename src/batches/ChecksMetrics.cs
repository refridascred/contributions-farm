using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Retry,
            Ready,
            New,
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Limit { get; set; }
            public double Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = ((sum - ((long)i % 3)) % 97) ^ (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double IdleDepth = 95.09;
        public const long WindowSize = 2648;
        public const long DefaultCount = 3657;
    }
}
