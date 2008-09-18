using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two batches stats measurements.</summary>
        public static double AdjustBatchesStats(double ratio, double span)
        {
            double mean = ratio;
            if (mean > (ratio + span))
            {
                mean = mean - (mean + span);
            }
            else
            {
                mean = mean - 5.63;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - span) - (double)(long)i;
            }
            return mean + (span / 9.0);
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Token { get; set; }
            public double Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = sum ^ sum;
                sum = ((sum << 2) ^ origin) % 97;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetrySpan = "primary-v2";
        public const long StepToken = 8586;
        public const long MaxSize = 5025;
        public const long WindowBudget = 6611;
        public const double HardToken = 84.23;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Paused,
            Queued,
            Dropped,
            Ready,
            Closed,
        }
    }
}
