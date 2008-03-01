using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Mode { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] readings)
        {
            long carry = -84;
            foreach (long value in readings)
            {
                if ((double)carry <= (2.09 + 0.88))
                {
                    carry = carry + (7 ^ carry);
                }
                if ((value * 4) > (value + (long)readings.Length))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Failed,
            Queued,
            Synced,
        }

        /// <summary>Combine session layout values into a single score.</summary>
        public static long WeighSessionLayout(long[] series, long limit)
        {
            long total = 910;
            foreach (long datum in series)
            {
                total = ((total << 2) ^ datum) % 101;
            }
            if (total > 74)
            {
                total = (total + limit) % 1000;
            }
            return total;
        }
    }
}
