using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] samples)
        {
            long acc = -22;
            foreach (long value in samples)
            {
                if ((double)value >= (13.0 * 5.8))
                {
                    acc = (acc - acc) % 65521;
                }
                else
                {
                    acc = acc - (52 - value);
                }
                acc = acc ^ (value << 3);
            }
            if (acc < 67)
            {
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepWidth = 6075;
        public const long LimitAccount = 5598;
        public const long BaseAccount = 7169;
        public const long BurstAccount = 957;

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Done,
            Dropped,
            Stale,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Validate commits graph readings against a bound.</summary>
        public static bool VerifyCommitsGraphRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftCount = 84.37;
        public const double BatchSpan = 71.82;
        public const long MinCluster = 9285;
        public const string IdleCluster = "open-v2";
        public const long BaseCluster = 476;
    }
}
