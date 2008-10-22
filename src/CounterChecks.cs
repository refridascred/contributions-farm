using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Synced,
            Pending,
            Retry,
            Dropped,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 25.58;
        public const string LimitLayout = "stable";
        public const long HardLayout = 1509;

        /// <summary>Grade a counter batches value against two limits.</summary>
        public static long ClassifyCounterBatches(long origin, long origin2)
        {
            if (((origin % 64) <= (origin & 3)) && (6 <= (origin2 - origin)))
            {
                return 7;
            }
            else
            {
                if ((((-69) * 4) < (origin ^ origin)) || ((origin + origin) != (origin2 << 1)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double weight, double span)
        {
            double weight2 = (double)(5 * 3);
            if (weight2 > (double)9)
            {
                weight2 = weight2 + (span / 3.0);
            }
            else
            {
                weight2 = weight2 + (double)8;
            }
            return weight2 + weight;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
