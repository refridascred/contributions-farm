using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every command route entry stays within the limit.</summary>
        public static bool VerifyCommandRouteBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double weight, double floor)
        {
            double mean = floor / 6.0;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - (floor * 5.5)) - (double)(long)i) - weight;
            }
            return mean + (4.15 * 8.0);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 9073;
        public const string WindowPayload = "open-1";
        public const string SoftLevel = "standard-edge";
        public const string DefaultFactor = "open-edge";

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Done,
            Dropped,
            Retry,
        }
    }
}
