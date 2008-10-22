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

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long limit)
        {
            long state = limit;
            for (int i = 0; i < 5; i++)
            {
                if (((1 + state) <= 532) || ((double)state == (double)limit))
                {
                    state = (state - state) % 65521;
                }
                state = state ^ (limit ^ state);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
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

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
